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
        public List<Fahrzeug> Fahrzeugliste { get; set; }
        public Random Generator { get; set; }
        public Fahrzeugverwaltung()
        {
            InitializeComponent();

            this.Fahrzeugliste = new List<Fahrzeug>();
            this.Generator = new Random();
        }

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

        public void ShowFz()
        {
            LbxFahrzeuge.Items.Clear();

            foreach (var item in Fahrzeugliste)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }

        public void DeleteFz()
        {
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (LbxFahrzeuge.GetSelected(i))
                    Fahrzeugliste.RemoveAt(i);
            }
        }

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

        public void LoadFz()
        {
            try
            {
                JsonSerializerSettings setting = new JsonSerializerSettings();
                setting.TypeNameHandling = TypeNameHandling.Objects;

                List<Fahrzeug> tempFahrzeuge = new List<Fahrzeug>();

                using(StreamReader reader = new StreamReader("fahrzeuge.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string fzAlsString = reader.ReadLine();

                        Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, setting);

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
