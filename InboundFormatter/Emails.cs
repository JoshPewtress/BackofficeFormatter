using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InboundFormatter
{

    public partial class Emails : Form
    {
        private readonly Selector _selector;
        private ToolTip toolTip = new ToolTip();

        public Emails(Selector selector)
        {
            InitializeComponent();
            _selector = selector;

            this.StartPosition = FormStartPosition.Manual;

            requestOtherRadioButton.Tag = requestOtherTextBox;
            actionOtherRadioButton.Tag = actionOtherTextBox;

            SetupPlaceholder(requestOtherTextBox, "Enabled when Other is selected. Enter reason here...", false);
            SetupPlaceholder(actionOtherTextBox, "Enabled when Other is selected. Enter reason here...", false);
            SetupPlaceholder(storeNumberTextBox, "Store #", true);

            requestOtherRadioButton.CheckedChanged += OtherRadioButton_CheckedChanged;
            actionOtherRadioButton.CheckedChanged += OtherRadioButton_CheckedChanged;

            requestOtherTextBox.Tag = "Enabled when Other is selected. Enter reason here...";
            actionOtherTextBox.Tag = "Enabled when Other is selected. Enter reason here...";
            storeNumberTextBox.Tag = "Store #";

            damageRadioButton.Tag = "Damaged";
            lostRadioButton.Tag = "Lost In-Transit";
            cancelRadioButton.Tag = "Customer Cancelled";

            refundRadioButton.Tag = "Refund listed products";
            resourceRadioButton.Tag = "Resource to new fulfilling location";

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(submitButton, "Accepted Formats for Formrouters:\nOrder|Work order|Sku\nOrder|Work order|Sku|Quantity\n\n" +
                "Accepted Formats for 3PL:\nOrder");
        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio && radio.Tag is TextBox linkedTextBox)
            {
                linkedTextBox.Enabled = radio.Checked;

                if (!radio.Checked)
                {
                    linkedTextBox.ForeColor = System.Drawing.Color.Gray;
                    linkedTextBox.Text = "Enabled when Other is selected. Enter reason here...";
                }
                else
                {
                    if (linkedTextBox.ForeColor == System.Drawing.Color.Gray)
                    {
                        linkedTextBox.Clear();
                        linkedTextBox.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        private void SetupPlaceholder(TextBox textBox, string placeholder, bool enabled)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
            if (enabled)
                textBox.Enabled = true;
            else
                textBox.Enabled = false;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null && tb.ForeColor == System.Drawing.Color.Gray)
            {
                tb.Text = "";
                tb.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag.ToString();
                tb.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private RadioButton GetCheckedRadioButton(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                    return rb;

                var found = GetCheckedRadioButton(ctrl);
                if (found != null)
                    return found;
            }
            return null;
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            _selector.StartPosition = FormStartPosition.Manual;
            _selector.Location = this.Location;

            _selector.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var submittedLines = EmailHelper.NormalizeInput(inputTextBox.Text);
            var requestOrders = EmailHelper.ProcessEmail(submittedLines);
            resultsDataGrid.DataSource = BuildDataTable(requestOrders);
            ClearOtherTextBoxes();
        }

        private DataTable BuildDataTable(Dictionary<string, (HashSet<string> WorkOrders, HashSet<string> Sku)> orders)
        {
            var output = new DataTable();

            output.Columns.Add("Store");
            output.Columns.Add("Order Numbers");
            output.Columns.Add("Work Orders");
            output.Columns.Add("Skus");

            var storeNumber = "";

            var requestRb = GetCheckedRadioButton(requestGroup);
            var actionRb = GetCheckedRadioButton(actionGroup);

            string requestText = "";
            string actionText = "";

            if (requestRb != null)
            {
                if (requestRb == requestOtherRadioButton)
                    requestText = requestOtherTextBox.Text;
                else
                    requestText = requestRb.Tag?.ToString();
            }

            if (actionRb != null)
            {
                if (actionRb == actionOtherRadioButton)
                    actionText = actionOtherTextBox.Text;
                else
                    actionText = actionRb.Tag?.ToString();
            }

            if (storeNumberTextBox.Text.Length == 4)
            {
                storeNumber = storeNumberTextBox.Text;
            }

            foreach (var keyValuePair in orders)
            {
                var skuString = string.Join(", ", keyValuePair.Value.Sku);

                if (!string.IsNullOrWhiteSpace(requestText))
                    skuString += $", {requestText}";
                if (!string.IsNullOrWhiteSpace(actionText))
                    skuString += $". {actionText}.";

                output.Rows.Add(
                    storeNumber,
                    keyValuePair.Key,
                    string.Join(", ", keyValuePair.Value.WorkOrders),
                    skuString
                );
            }

            return output;
        }

        private void ClearOtherTextBoxes()
        {
            requestOtherTextBox.Clear();
            actionOtherTextBox.Clear();
            storeNumberTextBox.Clear();
        }
    }
}
