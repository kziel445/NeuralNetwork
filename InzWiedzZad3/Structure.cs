using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InzWiedzZad1bV2
{
    //wersja 2/ zawiera funkcje zmiany "input'ów"/przyjmuje syntax jako array intów
     class Structure 
    {
        internal int[] syntaxInt;
        internal double[] inputs;
        internal double[][][] edgeValues;
        public Structure() { }
        public Structure(int[] syntax)
        {
            this.syntaxInt = syntax;
            this.inputs = new double[this.syntaxInt[0]];
            Array.Clear(inputs, 0, inputs.Length);
        }
        public Structure(int[] syntax, double[] inputs)
        {
            this.syntaxInt = syntax;
            this.inputs = inputs;
        }
        public bool Inputs(string newInputs)
        {
            double input;
            string[] inputsString = newInputs.Trim().Split(' ');
            if (inputsString.Length != syntaxInt[0]) return false;

            double[] inputsDouble = new double[inputsString.Length];
            for (int i = 0; i < inputsString.Length; i++)
            {
                if (double.TryParse(inputsString[i], out input))
                {
                    inputsDouble[i] = input;
                }
                else return false;
            }
            inputs = inputsDouble;
            return true;
        }
        public void Create(double min = 0, double max = 1)
        {
            Random rnd = new Random();
            int layer = syntaxInt.Length - 1,node,edge;
            
            edgeValues = new double[layer][][];//for syntax 3-2-2 theres 2 layers

            for (int i = 0; i < edgeValues.GetLength(0); i++)
            {
                node = syntaxInt[i + 1];
                edgeValues[i] = new double[node][];
                for (int j = 0; j < edgeValues[i].Length; j++)
                {
                    edge = syntaxInt[i]+1;
                    edgeValues[i][j] = new double[edge];
                    for (int k = 0; k < edgeValues[i][j].Length; k++)
                    {
                        //if (k == 0) edgeValues[i][j][k] = 1;
                        edgeValues[i][j][k] = (double)rnd.NextDouble() * (max - min) + min;

                    }
                }
            }
        }
        public string Show()
        {
            string scheme = "";
            for (int i = 0; i < inputs.Length; i++)
            {
                scheme += inputs[i] + " ";
            }
            for (int i = 0; i < edgeValues.Length; i++)
            {
                scheme += "\n";
                for (int j = 0; j < edgeValues[i].Length; j++)
                {
                    for (int k = 0; k < edgeValues[i][j].Length; k++)
                    {
                        scheme += edgeValues[i][j][k].ToString("F");
                        if (k == 0) scheme += " : ";
                        else if (k == edgeValues[i][j].Length - 1) { }
                        else scheme += " ";
                    }
                    if(j!=edgeValues[i].Length-1) scheme += " | ";
                }
            }
            return scheme;
        }
        public string findAndShow(string pathText)
        {
            string[] path = pathText.Split("-");
            int pathStep = 0;
            string scheme = "";
            bool pathSeted = false;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (int.Parse(path[pathStep]) == i + 1) 
                {
                    scheme += "(" + inputs[i] + ") ";
                }
                else
                {
                    scheme += inputs[i];
                    if (i != inputs.Length - 1) scheme += " ";
                }
            }
            pathStep++;

            for (int i = 0; i < edgeValues.Length; i++)
            {
                scheme += "\n";
                for (int j = 0; j < edgeValues[i].Length; j++)
                {

                    for (int k = 0; k < edgeValues[i][j].Length; k++)
                    {
                        if(int.Parse(path[pathStep - 1]) == k && int.Parse(path[pathStep]) - 1 == j && !pathSeted)
                        {
                                scheme += "(" + edgeValues[i][j][k].ToString("F") + ") ";
                        }
                        else
                        {
                            scheme += edgeValues[i][j][k].ToString("F");
                            if (k == 0) scheme += " : ";
                            else if (k == edgeValues[i][j].Length - 1) { }
                            else scheme += " ";
                        }
                        
                    }
                    if (j != edgeValues[i].Length - 1) scheme += " | ";
                }
                if (pathStep == path.Length - 1) pathSeted = true;
                else pathStep++;
            }
            return scheme;
        }
        public bool Save(string nameFile)
        {
            nameFile = nameFile.Trim();
            if (nameFile == null || nameFile == "") return false;
            string text = "";
            for (int i = 0; i < edgeValues.GetLength(0); i++)
            {
                if(i!=0) text += "\n";
                for (int j = 0; j < edgeValues[i].Length; j++)
                {
                    
                    for (int k = 0; k < edgeValues[i][j].Length; k++)
                    {
                        text += edgeValues[i][j][k];
                        if(k!= edgeValues[i][j].Length-1) text += " ";
                    }
                    if (j != edgeValues[i].Length - 1) text += "|";
                }
            }
            File.WriteAllText($"{nameFile}", text);
            return true;
        }
        public void Load(string path)
        {
            string content = File.ReadAllText(path);

            string[] rows = content.Split("\n"),segments,cells;
            int layer = rows.Length, node, edge;

            syntaxInt = new int[rows.Length + 1];
            
            edgeValues = new double[layer][][];//for syntax 3-2-2 theres 2 layers

            for (int i = 0; i < edgeValues.GetLength(0); i++)
            {
                segments = rows[i].Split("|");
                node = segments.Length;
                edgeValues[i] = new double[node][];
                
                syntaxInt[i + 1] = node;
                for (int j = 0; j < edgeValues[i].Length; j++)
                {                    
                    cells = segments[j].Split(" ");
                    edge = cells.Length;
                    edgeValues[i][j] = new double[edge];

                    if (i == 0)
                    {
                        syntaxInt[0] = edge - 1;
                        inputs = new double[syntaxInt[0]];
                        Array.Clear(inputs, 0, inputs.Length);
                    }
                    for (int k = 0; k < edgeValues[i][j].Length; k++)
                    {
                        edgeValues[i][j][k] = double.Parse(cells[k]);
                    }
                }
            }
        }
    }
}
