using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugpark;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Fahrzeugverwaltung : Form
    {
        //Benötigte Properties (Liste zum Speichern der Fahrzeuge und Zufallsgenerator)
        public List<Fahrzeug> Fahrzeugliste { get; set; }
        public Random Generator { get; set; }
        public Fahrzeugverwaltung()
        {
            InitializeComponent();

            //Initialisierung der Properties
            this.Fahrzeugliste = new List<Fahrzeug>();
            this.Generator = new Random();
        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        public Fahrzeug CreateNewFz()
        {
            switch (Generator.Next(1,4))
            {
                case 1:
                    return PKW.ErzeugeZufälligenPKW("");
                case 2:
                    return new Schiff("Titanic", 60, 3000000, Schiff.SchiffsTreibstoff.Dampf);
                case 3:
                    return new Flugzeug("Boing", 800, 3500000, 9999);
                default:
                    return null;
            }
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        public void ShowFz()
        {
            //Löschen der Listboxinhalte
            LbxFahrzeuge.Items.Clear();

            //Einfügen der Fahrzeuge aus der Liste in die Listbox
            foreach (var item in Fahrzeugliste)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }

        //Methode zum Löschen markierter Fahrzeugen
        public void DeleteFz()
        {
            //For-Schleife über die ListBox
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                //Prüfung, ob der aktuell betrachtete Eintrag vom Benutzer markiert ist
                if (LbxFahrzeuge.GetSelected(i))
                    //Löschen des Items aus der Fahrzeugliste an der aktuellen Indexposition
                    Fahrzeugliste.RemoveAt(i);
            }
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        public void SaveFz()
        {
            try
            {
                JsonSerializerSettings setting = new JsonSerializerSettings();
                setting.TypeNameHandling = TypeNameHandling.Objects;

                using(StreamWriter writer = new StreamWriter("fahrzeuge.txt"))
                {
                    for (int i = 0; i < Fahrzeugliste.Count; i++)
                    {
                        string fzAlsString = JsonConvert.SerializeObject(Fahrzeugliste[i], setting);

                        writer.WriteLine(fzAlsString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch 
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LadeText())
        public void LoadFz()
        {
            try
            {
                //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
                //zu ladenden/speichernden Objekte mit abspeichert
                JsonSerializerSettings setting = new JsonSerializerSettings();
                setting.TypeNameHandling = TypeNameHandling.Objects;

                List<Fahrzeug> tempFahrzeuge = new List<Fahrzeug>();

                using(StreamReader reader = new StreamReader("fahrzeuge.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        //Lesen einer Textzeile aus der Datei
                        string fzAlsString = reader.ReadLine();
                        //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                        Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, setting);
                        //Hinzufügen des Fahrzeugs zur Liste
                        tempFahrzeuge.Add(fz);
                    }
                }

                Fahrzeugliste = tempFahrzeuge;

                MessageBox.Show("Laden erfolgreich");

            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }

        //Click-Event-Methoden der Buttons
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Fahrzeugliste.Add(CreateNewFz());
            ShowFz();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteFz();
            ShowFz();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFz();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadFz();
            ShowFz();
        }
    }
}
