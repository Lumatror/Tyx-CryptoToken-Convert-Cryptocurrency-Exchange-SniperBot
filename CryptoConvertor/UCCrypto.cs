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
    public partial class UCCrypto : UserControl
    {
        public UCCrypto()
        {
            InitializeComponent();
        }

        public Image CryptoImage
        {
            get => pictureBox1.Image;
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string CryptoTitle
        {
            get => labelTitle.Text;
            set
            {
                labelTitle.Text = value;
            }
        }
        public string CryptoName
        {
            get => labelName.Text;
            set
            {
                labelName.Text = value;
            }
        }
        public string CryptoValue
        {
            get => label3.Text;
            set
            {
                label3.Text = value;
            }
        }
    }
}
