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

namespace SpeichernUndLaden
{
    public partial class Datenzugriff : Form
    {
        public Datenzugriff()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveText(TbxInput.Text);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            TbxInput.Text = LoadText();
        }

        public string LoadText()
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            string text = "";

            openDialog.FileName = "TestText.txt";
            openDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openDialog.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            text += reader.ReadLine() + Environment.NewLine; //"\r\n"
                        }
                    }

                    MessageBox.Show("Laden erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Laden fehlgeschlagen");
                }
            }
            return text;
        }

        public void SaveText(string text)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "TestText.txt";
            //saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(saveDialog.FileName);

                    writer.WriteLine(text);

                    writer.WriteLine("ENDE DER EINGABE");

                    MessageBox.Show("Speichern erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    if (writer != null)
                        writer.Close();

                    //writer?.Close();
                }
            }
        }
    }
}
