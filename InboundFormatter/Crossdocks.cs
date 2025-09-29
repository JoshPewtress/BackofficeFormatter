using InboundFormatter.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InboundFormatter
{
    public partial class Crossdocks : Form
    {
        private readonly Selector _selector;
        private ToolTip toolTip = new ToolTip();

        public Crossdocks(Selector selector)
        {
            InitializeComponent();
            _selector = selector;

            this.StartPosition = FormStartPosition.Manual;

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(submitButton, "Accepted Formats for Crossdocks:\nOrder|Work order|Sku|Quantity|Date\n\n" +
                "Open request in Browser or Excel, Delete or Hide description rows.");
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            _selector.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var submittedLines = CrossdockHelper.NormalizeInput(inputTextBox.Text);
            var requestOrders = CrossdockHelper.ProcessCrossdock(submittedLines);
            resultsGridView.DataSource = CrossdockHelper.BuildCrossdockTable(requestOrders);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }
    }
}
