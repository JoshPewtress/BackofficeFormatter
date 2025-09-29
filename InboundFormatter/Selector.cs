using System;
using System.Windows.Forms;

namespace InboundFormatter
{
    public partial class Selector : Form
    {
        private ToolTip toolTip = new ToolTip();

        public Selector()
        {
            InitializeComponent();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(emailButton, @"Able to process three or four columns Formrouter requests.
         As well as single column 3PL's");

            toolTip.SetToolTip(crossdockButton, @"Able to process 5 columns Crossdock requests.");
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            OpenForm(selector => new Emails(selector));
        }

        private void crossdockButton_Click(object sender, EventArgs e)
        {
            OpenForm(selector => new Crossdocks(selector));
        }

        private void OpenForm<T>(Func<Selector, T> formFactory) where T : Form
        {
            var form = formFactory(this);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;

            form.Show();
            this.Hide();
        }
    }
}
