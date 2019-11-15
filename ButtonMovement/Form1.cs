using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovement
{
    public partial class Form1 : Form
    {
        int BtnLeftStart, BtnRightStart;

        public Form1()
        {
            InitializeComponent();

            BtnLeftStart = BtnLeft.Left;
            BtnRightStart = BtnRight.Left;

            BtnMain.Click += BtnLeft_Click;
            BtnMain.Click += BtnRight_Click;
            BtnMain.Click += BtnMain_Click;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            BtnLeft.Left += 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            BtnRight.Left -= 10;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            if(BtnLeft.Right >= BtnRight.Left)
                if(MessageBox.Show("Die Buttons berühren sich.\nZurücksetzen?", "Berührung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BtnLeft.Left = BtnLeftStart;
                    BtnRight.Left = BtnRightStart;
                }
        }
    }
}
