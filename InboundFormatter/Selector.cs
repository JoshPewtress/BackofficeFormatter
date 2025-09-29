using System;
using System.Windows.Forms;

namespace InboundFormatter
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
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
