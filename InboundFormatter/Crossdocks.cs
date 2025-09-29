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

        public Crossdocks(Selector selector)
        {
            InitializeComponent();
            _selector = selector;

            this.StartPosition = FormStartPosition.Manual;
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
