using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Analizator_Lexical
{
    public partial class UI : Form
    {
        private Controller ctrl;
        string sursa;

        public UI()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "LFTC Files (*.lftc)|*.lftc";
            OFD.InitialDirectory = Directory.GetCurrentDirectory() + @"\Surse\";
            OFD.Title = "Load from file";
            DialogResult result = OFD.ShowDialog();

            while (result == DialogResult.OK)
            {
                bool Valid = true;
                foreach (string file in OFD.FileNames)
                {
                    if (Path.GetExtension(file) != ".lftc")
                    {
                        Valid = false;
                        break;
                    }
                }
                if (!Valid)
                {
                    MessageBox.Show("Fisier nevalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = OFD.ShowDialog();
                }
                else
                    break;
            }

            if (result == DialogResult.OK)
            {
                txtPath.Text = OFD.FileName;

                using (FileStream stream = File.Open(OFD.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string text = reader.ReadToEnd();
                        rchSursa.Clear();
                        sursa = text;
                        ctrl.setSursa(text);
                    }
                }

                ctrl.ctrlStartAnaliza();
                afiseazaRezultate();
                MessageBox.Show("Analiza finalizata cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void afiseazaRezultate()
        {
            List<int> fip1 = new List<int>();
            List<int> fip2 = new List<int>();
            List<string> ts1 = new List<string>();
            List<int> ts2 = new List<int>();

            fip1 = ctrl.getFIP1();
            fip2 = ctrl.getFIP2();
            ts1 = ctrl.getTS1();
            ts2 = ctrl.getTS2();

            FIPDataGridView.Rows.Clear();
            TSDataGridView.Rows.Clear();

            for (int i = 0; i < fip1.Count(); i++)
            {
                FIPDataGridView.Rows.Add();

                FIPDataGridView.Rows[i].Cells[0].Value = fip1[i];

                if (fip2[i] == -1)
                    FIPDataGridView.Rows[i].Cells[1].Value = "/";
                else
                    FIPDataGridView.Rows[i].Cells[1].Value = fip2[i];
            }

            for (int i = 0; i < ts1.Count(); i++)
            {
                TSDataGridView.Rows.Add();

                TSDataGridView.Rows[i].Cells[0].Value = ts1[i];
                TSDataGridView.Rows[i].Cells[1].Value = ts2[i];
            }

            List<string> errList = ctrl.getErrorList();

            string[] lines = sursa.Split('\n');
            rchSursa.Clear();
            rchErrorList.Clear();

            if (errList.Count() == 0)
                rchErrorList.AppendText("Nicio eroare gasita!");

            string lineNr = string.Empty;

            for (int i = 0; i < lines.Length; i++)
            {
                lineNr = i.ToString();

                while (lineNr.Length != lines.Length.ToString().Length)
                    lineNr += " ";

                lineNr += ": ";

                rchSursa.SelectionColor = Color.Green;
                rchSursa.AppendText(lineNr);

                if (errList.Count > 0)
                {
                    while (lines[i].Contains(errList[0]))
                    {
                        int index = lines[i].IndexOf(errList[0]);
                        string first, second;
                        first = lines[i].Substring(0, index);
                        second = lines[i].Substring(index, errList[0].Length);

                        rchSursa.SelectionFont = new Font(rchSursa.Font, FontStyle.Regular);
                        rchSursa.SelectionBackColor = Color.Black;
                        rchSursa.SelectionColor = Color.White;
                        rchSursa.AppendText(first);
                        rchSursa.SelectionFont = new Font(rchSursa.Font, FontStyle.Bold | FontStyle.Italic);
                        rchSursa.SelectionBackColor = Color.Gold;
                        rchSursa.SelectionColor = Color.Red;
                        rchSursa.AppendText(second);

                        lines[i] = lines[i].Substring(index + errList[0].Length);

                        rchErrorList.SelectionFont = new Font(rchErrorList.Font, FontStyle.Regular);
                        rchErrorList.SelectionColor = Color.Black;
                        rchErrorList.AppendText("Eroare gasita in linia " + i + ": \"");
                        rchErrorList.SelectionFont = new Font(rchErrorList.Font, FontStyle.Italic);
                        rchErrorList.SelectionColor = Color.Orange;
                        rchErrorList.AppendText(errList[0]);
                        rchErrorList.SelectionFont = new Font(rchErrorList.Font, FontStyle.Regular);
                        rchErrorList.SelectionColor = Color.Black;
                        rchErrorList.AppendText("\"\n");

                        errList.RemoveAt(0);
                        if (errList.Count() == 0)
                            break;
                    }

                    rchSursa.SelectionFont = new Font(rchSursa.Font, FontStyle.Regular);
                    rchSursa.SelectionBackColor = Color.Black;
                    rchSursa.SelectionColor = Color.White;
                    rchSursa.AppendText(lines[i] + "\n");
                }

                else
                {
                    rchSursa.SelectionColor = Color.White;
                    rchSursa.AppendText(lines[i] + "\n");
                }
            }
        }
    }
}

