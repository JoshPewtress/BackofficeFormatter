using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InboundFormatter.Helpers
{
    public static class CrossdockHelper
    {
        public static List<string> NormalizeInput(string input)
        {
            var output = new List<string>();
            var splitLines = input.Split(new[ ] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (var line in splitLines)
            {
                output.Add(line.Trim('\"'));
            }

            return output;
        }

        public static Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku, HashSet<string> Dates)> ProcessCrossdock(List<string> lines)
        {
            var output = new Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku, HashSet<string> Dates)>();

            foreach (var line in lines)
            {
                var parts = line.Split('\t');

                if (parts.Length == 5 && int.TryParse(parts[3].Trim(), out _))
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ].Trim()} Qty - {parts[ 3 ].Trim()}", parts[ 4 ] };
                }

                if (parts.Length != 4)
                {
                    if (string.IsNullOrEmpty(parts[0]))
                    {
                        continue;
                    }
                }

                string order = parts[ 0 ];
                string workOrder = parts[ 1 ];
                string sku = parts[ 2 ];
                string dates = parts[ 3 ];

                if (!output.ContainsKey(order))
                    output[ order] = (new HashSet<string>(), new HashSet<string>(), new HashSet<string>());

                output[ order ].WorkOrders.Add(workOrder);
                output[ order ].Sku.Add(sku);
                output[ order ].Dates.Add(dates);
            }

            return output;
        }

        public static DataTable BuildCrossdockTable(Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku, HashSet<string> Dates)> orders)
        {
            var table = new DataTable();
            table.Columns.Add("Order Number");
            table.Columns.Add("Work Orders");
            table.Columns.Add("Sku");
            table.Columns.Add("Delivery Dates");

            foreach (var kvp in orders)
            {
                table.Rows.Add(
                    kvp.Key,
                    string.Join(", ", kvp.Value.WorkOrders),
                    string.Join(", ", kvp.Value.Sku),
                    string.Join(", ", kvp.Value.Dates)
                );
            }

            return table;
        }
    }
}
