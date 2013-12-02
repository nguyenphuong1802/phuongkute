using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1241388
{
    public partial class ucTextBoxSo : UserControl
    {
        public ucTextBoxSo()
        {
            InitializeComponent();
        }

        public string GiaTriSo
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
