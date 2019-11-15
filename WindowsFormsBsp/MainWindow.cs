using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBsp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            BtnKlickMich.Click += BtnKlickMich_Click_2;

            CbbAuswahl.Items.Add("NeuerEintrag");

            BtnKlickMich.BringToFront();
        }

        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
            BtnKlickMich.Left += 10;

            (sender as Button).Left += 10;

            LblOutput.Text = CbbAuswahl.SelectedItem?.ToString();

            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void BtnKlickMich_Click_2(object sender, EventArgs e)
        {
            if (CbxHakMichAb.Checked)
                this.BackColor = Color.HotPink;
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new MainWindow()).ShowDialog();
        }

        private void fensterSchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnZeigeMB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Aber nicht mehr lange");
            }
            else
                MessageBox.Show("Das passiert halt mal");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnKlickMich.Top++;
        }
    }
}
