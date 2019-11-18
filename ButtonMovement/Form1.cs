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
        //Felder zum Zwischenspeichern der Startpositionswerte
        int BtnLeftStart, BtnRightStart;

        public Form1()
        {
            //Methode zum Erstellen der im Desigener definierten Elemente
            InitializeComponent();

            //Zwischenspeichern der Startwerte
            BtnLeftStart = BtnLeft.Left;
            BtnRightStart = BtnRight.Left;

            //Anmelden der Methoden am Click-Event des dritten Buttons
            BtnMain.Click += BtnLeft_Click;
            BtnMain.Click += BtnRight_Click;
            BtnMain.Click += BtnMain_Click;
        }

        //Event-Handler-Methode des linken Buttons
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            //Bewegen des linken Buttons um 10 Pixel nach rechts
            BtnLeft.Left += 10;
        }

        //Event-Handler-Methode des rechten Buttons
        private void BtnRight_Click(object sender, EventArgs e)
        {
            //Bewegen des rechten Buttons um 10 Pixel nach links
            BtnRight.Left -= 10;
        }

        //Weitere Event-Handler-Methode
        private void BtnMain_Click(object sender, EventArgs e)
        {
            //Prüfung, ob die Buttons sich überlagern
            if(BtnLeft.Right >= BtnRight.Left)
                //Messagebox-Aufruf mit Abfrage, ob die Buttons zurückgesetzt werden sollen
                if(MessageBox.Show("Die Buttons berühren sich.\nZurücksetzen?", "Berührung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Belegung der Buttonspositionen mit den gespeicherten Startwerten
                    BtnLeft.Left = BtnLeftStart;
                    BtnRight.Left = BtnRightStart;
                }
        }
    }
}
