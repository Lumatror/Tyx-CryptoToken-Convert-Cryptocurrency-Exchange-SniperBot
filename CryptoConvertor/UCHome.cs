using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptoConvertorDemo
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Converting Started.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("The hash screen will appear in a few minutes..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
