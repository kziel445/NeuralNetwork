using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;
using InzWiedzZad1bV2;

namespace InzWiedzZad3
{
    public partial class Form1 : Form
    {

        Structure structure;

        public Form1()
        {
            InitializeComponent();
            btnPath.Enabled = false;
        }
        private void showCentered()
        {
            rtbMain.Text = structure.Show();
            rtbMain.SelectAll();
            rtbMain.SelectionAlignment = HorizontalAlignment.Center;
        }
        //buttons
        private void btnCreate_Click(object sender, EventArgs e)
        {
            rtbMain.Text = "";
            //obsługa błędów schematu
            string[] syntaxText = tbStyntax.Text.Split('-');
            int[] syntaxInt = new int[syntaxText.Length];
            for (int i = 0; i < syntaxText.Length; i++)
            {
                if (!int.TryParse(syntaxText[i], out syntaxInt[i]))
                {
                    tbStatus.Text = "Zle podano schemat";
                    return;
                }
            }

            structure = new Structure(syntaxInt);
            double min = 0, max = 1;
            if (!double.TryParse(tbMin.Text, out min) || !double.TryParse(tbMax.Text, out max))
            {
                tbStatus.Text = "Podano nieodpowiednie znaki zakresu";
                return;
            }
            structure.Create(min, max);
            showCentered();
            
            btnPath.Enabled = true;
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Split('-').Length == 1)
            {
                tbStatus.Text = "Ścieżka musi mieć conajmniej 2 wartości przedzielone '-'";
                return;
            }
            rtbMain.Text = structure.findAndShow(tbPath.Text);
            rtbMain.SelectAll();
            rtbMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Otwórz plik z danymi";
            openFile.ShowDialog();
            string path = openFile.FileName;
            if (path == null || path == "")
            {
                tbStatus.Text = "Nie udało się wczytać pliku";
                return;
            }
            structure = new Structure();
            structure.Load(path);
            showCentered();
            tbStatus.Text = "Plik wczytany";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (structure.Save(tbExport.Text)) tbStatus.Text = "Zapisano";
            else tbStatus.Text = "Nie udało się zapisać";

        }
        public double[] asked;
        string[] samples= new string[0];
        double[] givenQuestion;
        private void btnInputs_Click(object sender, EventArgs e)
        {
            samples = new string[1];
            samples[0] = tbInputs.Text;

            tbSamples.Text = tbInputs.Text;
            showCentered();
        }

        private void btnInputsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Otwórz plik z probkami";
            openFile.ShowDialog();
            string path = openFile.FileName;
            if (path == null || path == "")
            {
                tbStatus.Text = "Nie udało się wczytać pliku";
                return;
            }
            samples = File.ReadAllLines(path);

            tbSamples.Text = File.ReadAllText(path)+"\n";
            tbStatus.Text = "Plik wczytany";
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            tbStatus.Text = "";
            double mi, B;
            int iteration = 1;
            double error = 0;
            if (chkBoxIteration.Checked)
            {
                if (!int.TryParse(tbIteration.Text, out iteration))
                {
                    tbStatus.Text = "Popraw liczbe iteracji";
                    return;
                }
            }
            if (chkBoxError.Checked)
            {
                if (!double.TryParse(tbError.Text, out error))
                {
                    tbStatus.Text = "Popraw dopuszczalny blad";
                    return;
                }
            }

            if (!double.TryParse(tbLearning.Text, out mi))
            {
                tbStatus.Text = "Popraw liczbe mi";
                return;
            }
            if (!double.TryParse(tbB.Text, out B))
            {
                tbStatus.Text = "Popraw liczbe B";
                return;
            }
            NeuralNetwork correction = new NeuralNetwork(structure, asked, B, mi);
            //użycie danych próbek
            string[] sampleSliced = samples[0].Split('|');
            double[,] given = new double[samples.Length, sampleSliced[0].Split(' ').Length];
            double[,] result = new double[samples.Length, sampleSliced[1].Split(' ').Length];
            for (int i = 0; i < samples.Length; i++)
            {
                string[] sampleArray = samples[i].Split('|');
                string[] givenSample = sampleArray[0].Split(' ');
                for (int j = 0; j < givenSample.Length; j++)
                {
                    double.TryParse(givenSample[j], out given[i, j]);
                }
                string[] resultSample = sampleArray[1].Split(' ');
                for (int j = 0; j < resultSample.Length; j++)
                {
                    double.TryParse(resultSample[j], out result[i, j]);
                }
            }
            //wykonanie iteracji
            for (int i = 0; i < iteration; i++)
            {
                if(cbEpoch.Checked) correction.FullCorrectionEpoch(given, result);
                else correction.FullCorrection(given, result);

                //wykonuje sie przy zanzaczeniu iteracji zwiazanej z błędem
                if (chkBoxError.Checked)
                {
                    int lastIndexOfOutputs = correction.IO.Length - 1;
                    for (int j = 0; j < correction.IO[lastIndexOfOutputs].Length; j++)
                    {
                        int iterration2 = iteration;
                        for (int k = 0; k < result.GetLength(0); k++)
                        {
                            string givenString = "";
                            for (int m = 0; m < given.GetLength(1); m++)
                            {
                                givenString += given[k, m].ToString() + " ";
                                correction.IO[0][m] = given[k, m];
                            }
                            structure.Inputs(givenString);
                            for (int m = 0; m < correction.valueAskedD.Length; m++)
                            {
                                correction.valueAskedD[m] = result[k, m];
                            }
                            correction.OutputMaker();
                            if (result[k, j] - error > correction.IO[lastIndexOfOutputs][j] || result[k, j] + error < correction.IO[lastIndexOfOutputs][j])
                            {
                                iteration++;
                                break;
                            }
                        }
                        if (iterration2 < iteration) break;
                    }
                }
            }

            showCentered();
            correction.OutputMaker();
            for (int i = 0; i < correction.IO[correction.IO.Length - 1].Length; i++)
            {
                tbStatus.Text += correction.IO[correction.IO.Length - 1][i] + " ";
            }
            if (chkBoxError.Checked) tbStatus.Text += "\nWykonanych iteracji: " + iteration;

        }
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            tbStatus.Text = "";
            structure.Inputs(tbQuestion.Text);
            NeuralNetwork correction = new NeuralNetwork(structure, asked);
            correction.OutputMaker();
            for (int i = 0; i < correction.IO[correction.IO.Length - 1].Length; i++)
            {
                tbStatus.Text += correction.IO[correction.IO.Length - 1][i] + " ";
            }
            showCentered();
        }
        //textboxes

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {

        }

        public void tbStyntax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMax_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbExport_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbIteration_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLearning_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbSamples_TextChanged(object sender, EventArgs e)
        {

        }
        //other
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tab2_Click(object sender, EventArgs e)
        {

        }

        
        //checkboxy
        private void chkBoxError_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxError.Checked)
            {
                chkBoxIteration.Checked = false;
                tbIteration.ReadOnly = true;
                tbError.ReadOnly = false;
            }

        }

        private void chkBoxIteration_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxIteration.Checked)
            {
                chkBoxError.Checked = false;
                tbError.ReadOnly = true;
                tbIteration.ReadOnly = false;
            }

        }

        private void cbEpoch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
