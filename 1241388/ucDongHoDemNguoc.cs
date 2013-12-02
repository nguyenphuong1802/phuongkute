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
    public partial class ucDongHoDemNguoc : UserControl
    {
        private bool dangChay = false;
        private int gio;

        [Browsable(true)]
        public int Gio
        {
            get { return gio; }
            set
            {
                gio = value;
                if (gio < 0)
                {
                    gio = 0;
                    Phut = 0;
                    Giay = 0;
                    dangChay = false;
                }
                labelGio.Text = String.Format("{0:00}", gio);
            }
        }
        private int phut;

        [Browsable(true)]
        public int Phut
        {
            get { return phut; }
            set
            {
                phut = value;
                if (phut < 0)
                {
                    phut = 59;
                    Gio--;
                }
                labelPhut.Text = String.Format("{0:00}", phut);
            }
        }
        private int giay;

        [Browsable(true)]
        public int Giay
        {
            get { return giay; }
            set
            {
                giay = value;
                if (giay < 0)
                {
                    giay = 59;
                    Phut--;
                }
                labelGiay.Text = String.Format("{0:00}", giay);
            }
        }

        public ucDongHoDemNguoc()
        {
            InitializeComponent();
        }

        public void Dung()
        {
            timer1.Enabled = false;
            dangChay = false;
        }

        public void Chay()
        {
            timer1.Enabled = true;
            dangChay = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Giay--;
            if (!dangChay)
            {
                timer1.Enabled = false;
                MessageBox.Show(":( Hết giờ gùi!");
                label1.Visible = true;
                label2.Visible = true;
            }

            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;

            labelGio.Text = String.Format("{0:00}", gio);
            labelPhut.Text = String.Format("{0:00}", phut);
            labelGiay.Text = String.Format("{0:00}", giay);

        }

    }
}
