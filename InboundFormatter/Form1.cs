using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InboundFormatter
{
    public partial class InboundFormatter : Form
    {
        private ToolTip toolTip = new ToolTip();

        public InboundFormatter()
        {
            InitializeComponent();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(processButton, @"Format: Order Number | Work Order | SKU | Quantity (Optional)
               Additional tabs, Quotations or white space can break tool.");

            toolTip.SetToolTip(crossdockButton, @"Format: Order Number | Work Order | SKU | Quantity | Delivery Date
               Additional tabs, Quotations or white space can break tool.
               Delete columns 'D' and 'F' from the MDO submitted Excel sheet for easier copy and pasting");
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            var submittedLines = NormalizeInputLines(inputTextBox.Text);
            var orders = ParseEmailOrders(submittedLines);
            resultsGrid.DataSource = BuildDataTable(orders);
        }

        private void crossdockButton_Click(object sender, EventArgs e)
        {
            var submittedLines = NormalizeInputLines(inputTextBox.Text);
            var orders = ParseCrossdockOrders(submittedLines);
            resultsGrid.DataSource = BuildCrossdockTable(orders);
        }

        // Normalizes multiline input while preserving quoted cells with newlines
        private List<string> NormalizeInputLines(string input)
        {
            var rawLines = input.Split(new[ ] { "\r\n", "\n" }, StringSplitOptions.None);
            var submittedLines = new List<string>();
            var buffer = new StringBuilder();
            bool insideQuotes = false;

            foreach (var rawLine in rawLines)
            {
                if (insideQuotes)
                {
                    buffer.AppendLine(rawLine);
                    if (rawLine.Contains("\""))
                    {
                        insideQuotes = false;
                        submittedLines.Add(buffer.ToString());
                        buffer.Clear();
                    }
                }
                else
                {
                    if (rawLine.Count(c => c == '"') % 2 != 0)
                    {
                        buffer.AppendLine(rawLine);
                        insideQuotes = true;
                    }
                    else
                    {
                        submittedLines.Add(rawLine);
                    }
                }
            }

            return submittedLines;
        }

        // Parses normalized lines into structured order data
        private Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus)> ParseLinesToOrders(List<string> lines, bool appendQuantityToSku)
        {
            var orders = new Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus)>();

            foreach (var line in lines)
            {
                var parts = line.Split('\t');

                // If workorder has a false tab afterwards combine false tab into the workorder
                if (parts.Length == 4 && parts[ 2 ].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 4 && parts[1].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 4 && int.TryParse(parts[ 3 ].Trim(), out _) && appendQuantityToSku)
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ].Trim()} Qty - {parts[ 3 ].Trim()}" };
                }

                if (( appendQuantityToSku && parts.Length != 3 ) || ( !appendQuantityToSku && parts.Length != 3 && parts.Length != 4 ))
                {
                    continue;
                }

                string orderNumber = SplitCombinedOrderNumber(parts[ 0 ]);
                var rawWorkOrder = SplitCombinedWorkOrder(parts[ 1 ]);
                var workOrder = Regex.Replace(rawWorkOrder, @"^[^\d]*", "");

                var sku = NormalizeSkuBlock(parts[ 2 ]);

                if (!orders.ContainsKey(orderNumber))
                {
                    orders[ orderNumber ] = (new HashSet<string>(), new HashSet<string>());
                }

                orders[ orderNumber ].WorkOrders.Add(workOrder);
                orders[ orderNumber ].Skus.Add(sku);
            }

            return orders;
        }

        private Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus)> ParseEmailOrders(List<string> lines)
        {
            var orders = new Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus)>();

            foreach (var line in lines)
            {
                var parts = line.Split('\t');

                // Fix known formatting issues
                if (parts.Length == 4 && parts[ 2 ].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 4 && parts[ 1 ].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 4 && int.TryParse(parts[ 3 ].Trim(), out _))
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ].Trim()} Qty - {parts[ 3 ].Trim()}" };
                }

                if (parts.Length != 3) continue;

                string order = SplitCombinedOrderNumber(parts[ 0 ]);
                string work = Regex.Replace(SplitCombinedWorkOrder(parts[ 1 ]), @"^[^\d]*", "");
                string sku = NormalizeSkuBlock(parts[ 2 ]);

                if (!orders.ContainsKey(order))
                    orders[ order ] = (new HashSet<string>(), new HashSet<string>());

                orders[ order ].WorkOrders.Add(work);
                orders[ order ].Skus.Add(sku);
            }

            return orders;
        }

        private Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus, HashSet<string> Dates)> ParseCrossdockOrders(List<string> lines)
        {
            var orders = new Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus, HashSet<string> Dates)>();

            foreach (var line in lines)
            {
                var parts = line.Split('\t');

                // Fix known formatting issues
                if (parts.Length == 5 && parts[ 2 ].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 5 && parts[ 1 ].Trim() == "\"")
                {
                    parts[ 1 ] += parts[ 2 ];
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], parts[ 3 ] };
                }
                else if (parts.Length == 5 && int.TryParse(parts[ 3 ].Trim(), out _))
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ].Trim()} Qty - {parts[ 3 ].Trim()}", parts[4] };
                }

                if (parts.Length != 4) 
                {
                    if (string.IsNullOrEmpty(parts[0]))
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid line format. Please ensure each line has exactly 5 columns.",
                        "Formatting Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                } 

                string order = SplitCombinedOrderNumber(parts[ 0 ]);
                string work = Regex.Replace(SplitCombinedWorkOrder(parts[ 1 ]), @"^[^\d]*", "");
                string sku = NormalizeSkuBlock(parts[ 2 ]);
                string dates = parts[ 3 ].Trim('"');

                if (!orders.ContainsKey(order))
                    orders[ order ] = (new HashSet<string>(), new HashSet<string>(), new HashSet<string>());

                orders[ order ].WorkOrders.Add(work);
                orders[ order ].Skus.Add(sku);
                orders[ order ].Dates.Add(dates);
            }

            return orders;
        }

        // Converts dictionary into a DataTable
        private DataTable BuildDataTable(Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus)> orders)
        {
            var table = new DataTable();
            table.Columns.Add("Order Number");
            table.Columns.Add("Work Orders");
            table.Columns.Add("Sku's");

            foreach (var kvp in orders)
            {
                table.Rows.Add(
                    kvp.Key,
                    string.Join(", ", kvp.Value.WorkOrders),
                    string.Join(", ", kvp.Value.Skus)
                );
            }

            return table;
        }

        private DataTable BuildCrossdockTable(Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Skus, HashSet<string> Dates)> orders)
        {
            var table = new DataTable();
            table.Columns.Add("Order Number");
            table.Columns.Add("Work Orders");
            table.Columns.Add("Skus");
            table.Columns.Add("Delivery Dates");

            foreach (var kvp in orders)
            {
                table.Rows.Add(
                    kvp.Key,
                    string.Join(", ", kvp.Value.WorkOrders),
                    string.Join(", ", kvp.Value.Skus),
                    string.Join(", ", kvp.Value.Dates)
                );
            }

            return table;
        }

        private string SplitCombinedOrderNumber(string input)
        {
            var hyphenCount = input.Count(h => h == '-');

            if (hyphenCount == 2)
            {
                var secondHyphenIndex = input.LastIndexOf('-');

                if (secondHyphenIndex >= 0 && secondHyphenIndex < input.Length - 1)
                {
                    return input.Substring(0, secondHyphenIndex).Trim('"');
                }
            }

            if (input.Length > 12)
            {
                var hyphenIndex = input.IndexOf('-');

                return input.Substring(0, hyphenIndex).Trim('"');
            }

            return input.Trim('"');
        }

        private string SplitCombinedWorkOrder(string input)
        {
            var hyphenCount = input.Count(h => h == '-');

            if (hyphenCount == 2)
            {
                var secondHyphenIndex = input.LastIndexOf('-');

                if (secondHyphenIndex >= 0 && secondHyphenIndex < input.Length - 1)
                {
                    return input.Substring(secondHyphenIndex + 1).Trim('"');
                }
            }

            if (input.Length > 12)
            {
                var hyphenIndex = input.IndexOf('-');

                return input.Substring(hyphenIndex + 1).Trim('"');
            }

            return input.Trim('"');
        }

        /*
         Removes Dashes from Sku numbers and inserts spaces between Qty blocks and Sku blocks
         */
        private string NormalizeSkuBlock(string sku)
        {
            var output = RemoveDash(sku);

            output = BreakSkuLines(output);

            return output;
        }

        private string RemoveDash(string sku)
        {
            var output = string.Empty;

            if (sku.Contains("-"))
            {
                output = Regex.Replace(sku, "-", "");
            }
            else
            {
                output = sku;
            }

                return output.Trim().Trim('"');
        }

        private string BreakSkuLines(string output)
        {
            return output.Replace("\r\n", " ").Replace("\n", " ").Trim('"', ' ');
        }

        private void Button_HoverEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.LightSteelBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;
            }
        }

        private void Button_HoverLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = SystemColors.Control;
                btn.FlatStyle = FlatStyle.Standard;
                btn.Cursor = Cursors.Default;
            }
        }
    }
}
