using System;
using System.Collections.Generic;
using System.Text;
using InzWiedzZad1bV2;

namespace InzWiedzZad3
{
    class NeuralNetwork
    {
        public double learningFactorU; //wspolczynnik uczenia (0;1)
        public double[] valueAskedD; //wartosc zadana/ 1 0 to 1 bo bramka xor
        public double valueRecivedY; // wartisc otrzymana 
        //public double[][] correctionValue;
        //D - Y - błąd(korekta)
        public double B;

        public Structure structure;
        public double[][] IO;//input/output
        public NeuralNetwork(Structure structure, double[] asked, double B = 1, double learningFactorU = 0.1)
        {
            this.structure = structure;
            IO = new double[structure.syntaxInt.Length][];
            for (int i = 0; i < structure.syntaxInt.Length; i++)
            {
                IO[i] = new double[structure.syntaxInt[i]];
            }
            IO[0] = structure.inputs;
            this.valueAskedD = asked;
            this.B = B;
            this.learningFactorU = learningFactorU;
        }
        public double SigmaInputs(int layerIndex, int nodeIndex)
        {
            double sigmaInputs = structure.edgeValues[layerIndex][nodeIndex][0];
            for (int i = 1; i < structure.edgeValues[layerIndex][nodeIndex].Length; i++)
            {
                sigmaInputs += structure.edgeValues[layerIndex][nodeIndex][i] * IO[layerIndex][i - 1];
            }

            return sigmaInputs;
        }
        public double OutputLayerNode(int layerIndex, int nodeIndex)//Wy LA, NB
        {
            double sigmaInputs = SigmaInputs(layerIndex, nodeIndex);
            double power = -1 * B * sigmaInputs;
            double output = 1 / (1 + Math.Pow((Math.E), power));

            return output;
        }
        public void OutputMaker()
        {
            for (int i = 1; i < IO.Length; i++)
            {
                for (int j = 0; j < IO[i].Length; j++)
                {
                    IO[i][j] = OutputLayerNode(i - 1, j);
                }
            }
        }

        public bool DoubleToBool(double value)
        {
            if (value == 1) return true;
            else return false;
        }
        public void FullCorrection2()
        {
            int j = 0, i = 0;
            double tmp = DeltaS(i, j);
            for (i = structure.edgeValues.Length - 1; i >= 0; i--)
            {
                for (j = 0; j < structure.edgeValues[i].Length; j++)
                {
                    Correction(i, j, tmp);
                }
            }
        }

        public void FullCorrectionEpoch(double[,] given, double[,] result)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int indexLayer = structure.edgeValues.Length - 1;
            List<bool> ifDone = new List<bool>();
            int randomIndex;
            for (int indexNode = 0; indexNode < structure.edgeValues[indexLayer].Length; indexNode++)
            {
                ifDone.Clear();
                    
                for (int j = 0; j < given.GetLength(0); j++)
                {

                    for (int i = 0; i < given.GetLength(0); i++)
                    {
                        ifDone.Add(false);
                    }

                    while (true)
                    {
                        randomIndex = rnd.Next(0, given.GetLength(0));
                        if (!ifDone[randomIndex])
                        {
                            ifDone[randomIndex] = true;
                            break;
                        }
                        else if (!ifDone.Contains(false)) break;

                    };
                    valueAskedD = new double[result.GetLength(1)];
                    for (int i = 0; i < valueAskedD.Length; i++)
                    {
                        valueAskedD[i] = result[randomIndex, i];
                    }
                    for (int i = 0; i < given.GetLength(1); i++)
                    {
                        IO[0][i] = given[randomIndex, i];
                    }
                    OutputMaker();
                    Correction(indexLayer, indexNode, DeltaS(indexLayer, indexNode));
                }
            }
        }

        public void FullCorrection(double[,] given, double[,] result)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int indexLayer = structure.edgeValues.Length - 1;


            for (int indexNode = 0; indexNode < structure.edgeValues[indexLayer].Length; indexNode++)
            {
                
                int randomIndex;
                randomIndex = rnd.Next(0, given.GetLength(0));

                valueAskedD = new double[result.GetLength(1)];
                for (int i = 0; i < valueAskedD.Length; i++)
                {
                    valueAskedD[i] = result[randomIndex, i];
                }
                for (int i = 0; i < given.GetLength(1); i++)
                {
                    IO[0][i] = given[randomIndex, i];
                }
                OutputMaker();
                Correction(indexLayer, indexNode, DeltaS(indexLayer, indexNode));
            }
        }

        public void Correction(int layerIndex, int nodeIndex, double deltaS)
        {
            double cInputs;
            double bOutputs = 0;

            for (int j = 0; j < structure.edgeValues[layerIndex][nodeIndex].Length; j++)
            {
                //wzór deltaWe
                if (j == 0) cInputs = 1;
                else cInputs = CInputs(layerIndex, j - 1);
                //
                if (j != 0) bOutputs = BOutputs(layerIndex, j - 1);
                double deltaSNext = deltaS * structure.edgeValues[layerIndex][nodeIndex][j];
                structure.edgeValues[layerIndex][nodeIndex][j] += deltaS * cInputs;
                if (layerIndex >= 1 && j != 0)
                {
                    Correction(layerIndex - 1, j - 1, deltaSNext * bOutputs);
                }
            }
        }
        //wzory
        public double CInputs(int layerIndex, int edgeIndex)
        {
            return IO[layerIndex][edgeIndex];
        }
        public double DeltaS(int layerIndex, int nodeIndex)
        {
            return DeltaWy(IO[layerIndex + 1][nodeIndex], valueAskedD[nodeIndex]) * BOutputs(layerIndex + 1, nodeIndex);
        }
        public double DeltaWy(double value, double asked)//delta wy
        {
            return learningFactorU * (asked - value);
        }
        public double BOutputs(int layerIndex, int nodeIndex)
        {
            double output = IO[layerIndex][nodeIndex];
            return B * output * (1 - output);
        }
    }
}
