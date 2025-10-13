using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InboundFormatter
{
    public static class EmailHelper
    {
        public enum OrderType
        {
            Order,
            WorkOrder
        }

        public static List<string> NormalizeInput(string input)
        {
            var output = new List<string>();
            var sb = new StringBuilder();

            int tabCount = 0;
            char previousChar = '\0';

            foreach (var c in input)
            {
                if (c == '\t')
                {
                    if (previousChar == '\t')
                    {
                        tabCount++;
                    }

                    tabCount++;
                    sb.Append(c);
                }
                else if (c == '\n')
                {
                    // Valid newline if we have seen at least 3 tab characters in this row
                    if (tabCount >= 3)
                    {
                        output.Add(sb.ToString().Trim('\"', ' '));
                        sb.Clear();
                        tabCount = 0;
                    }
                    else
                    {
                        // Invalid embedded \n character -> replace with space
                        sb.Append(' ');
                    }
                }
                else if (c == '\r')
                {
                    output.Add(sb.ToString().Trim('\"', ' '));
                    sb.Clear();
                    tabCount = 0;
                }
                else if (c != '\r')
                {
                    sb.Append(c);
                }

                previousChar = c;
            }

            if (sb.Length > 0)
                output.Add(sb.ToString().Trim('\"', ' '));

            return output;
        }

        public static Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku)> ProcessEmail(List<string> lines)
        {
            var output = new Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku)>();

            foreach (var line in lines)
            {
                var parts = line.Split('\t');

                // Remove null rows caused by invalid \n characters
                if (line == "")
                    continue;

                // Collapse 4 column rows (with quantity in 4th col) into a 3-column format
                if (parts.Length == 4 && int.TryParse(parts[ 3 ].Trim(), out _))
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ]} Qty - {parts[ 3 ]}" };
                }
                else if (parts.Length == 4)
                {
                    parts = new[ ] { parts[ 0 ], parts[ 1 ], $"{parts[ 2 ]} {parts[ 3 ]}" };
                }

                if (parts.Length != 1 && parts.Length != 3)
                    continue;

                var orderNumber = RemoveAdditionalOrderInformation(parts[ 0 ], OrderType.Order);
                string workOrder = string.Empty;
                string skuNumber = string.Empty;

                if (parts.Length == 3)
                {
                    if (!string.IsNullOrWhiteSpace(parts[1]) && !string.IsNullOrWhiteSpace(parts[2]))
                    {
                        var trimmedWorkOrder = RemoveAdditionalOrderInformation(parts[ 1 ], OrderType.WorkOrder);
                        workOrder = Regex.Replace(trimmedWorkOrder, @"^[^\d]*", "");
                        skuNumber = parts[ 2 ].Trim('\"', ' ');
                    }

                    if (string.IsNullOrWhiteSpace(parts[1]) && parts[2].Length > 0)
                    {
                        skuNumber = parts[ 2 ].Trim('\"', ' ');
                    }
                }

                if (!output.ContainsKey(orderNumber))
                {
                    output[ orderNumber ] = (new HashSet<string>(), new HashSet<string>());
                }

                output[ orderNumber ].WorkOrders.Add(workOrder);
                output[ orderNumber ].Sku.Add(skuNumber);
            }

            return output;
        }

        private static string RemoveAdditionalOrderInformation(string value, OrderType type)
        {
            int hyphenCount = value.Count(h => h == '-');

            switch (type)
            {
                case OrderType.Order:
                    if (value.StartsWith("H", StringComparison.OrdinalIgnoreCase) && hyphenCount == 1)
                    {
                        break;
                    }

                    if (value.StartsWith("H", StringComparison.OrdinalIgnoreCase) && hyphenCount > 1)
                    {
                        return TrimAfterLastHyphen(value);
                    }
                    else if (hyphenCount > 0)
                    {
                        return TrimAfterLastHyphen(value);
                    }
                    break;

                case OrderType.WorkOrder:
                    if (value.StartsWith("H", StringComparison.OrdinalIgnoreCase) && hyphenCount > 1)
                    {
                        return TrimBeforeLastHyphen(value);
                    }
                    else if (hyphenCount > 0)
                    {
                        return TrimBeforeLastHyphen(value);
                    }
                    break;
            }
            return value.Trim('\"', ' ');
        }

        private static string TrimAfterLastHyphen(string value)
        {
            var extraHyphen = value.LastIndexOf('-');
            return value.Substring(0, extraHyphen).Trim('\"', ' ');
        }

        private static string TrimBeforeLastHyphen(string value)
        {
            var extraHyphen = value.LastIndexOf('-');
            return value.Substring(extraHyphen + 1).Trim('\"', ' ');
        }
    }
}
