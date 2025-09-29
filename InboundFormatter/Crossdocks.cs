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
    }
}
