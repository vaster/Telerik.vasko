using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquid
{
    public struct Cube
    {
        public int Value { get; set; }
        public bool IsVisited { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public int LayerIndex { get; set; }
    }

    internal class Program
    {
        public static int WIDTH;
        public static int HEIGHT;
        public static int DEPTH;

        public static void ReadInput(List<Cube[,]> matrixes)
        {
            string cuboidInfo = Console.ReadLine();
            string[] parameters = cuboidInfo.Split(' ');

            Program.WIDTH = int.Parse(parameters[0]);
            Program.HEIGHT = int.Parse(parameters[1]);
            Program.DEPTH = int.Parse(parameters[2]);

            Cube[,] liquid = null;

            Program.InitilizaMatrixes(matrixes);
            Program.InitilizeLiquid(liquid);

            string[] layerRows = null;
            for (int row = 0; row < Program.HEIGHT; row++)
            {
                layerRows = Console.ReadLine().Split('|');
                string[] layerRowNumbers = null;
                for (int layer = 0; layer < layerRows.Length; layer++)
                {
                    layerRowNumbers = layerRows[layer].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int col = 0; col < layerRowNumbers.Length; col++)
                    {
                        matrixes[layer][row, col].Value = int.Parse(layerRowNumbers[col]);
                        matrixes[layer][row, col].Row = row;
                        matrixes[layer][row, col].Col = col;
                        matrixes[layer][row, col].LayerIndex = layer;
                    }
                }
            }
        }


        public static void InitilizaMatrixes(List<Cube[,]> matrixes)
        {
            Cube[,] currMatrix = null;
            for (int layer = 0; layer < Program.DEPTH; layer++)
            {
                currMatrix = new Cube[Program.HEIGHT, Program.WIDTH];
                matrixes.Add(currMatrix);
            }
        }

        public static void InitilizeLiquid(Cube[,] liquid)
        {
            liquid = new Cube[Program.HEIGHT, Program.WIDTH];
            for (int row = 0; row < Program.HEIGHT; row++)
            {
                for (int col = 0; col < Program.WIDTH; col++)
                {
                    liquid[row, col].Value = int.MaxValue;
                }
            }
        }


        public static int CalcLiquidPass()
        {
            int sum = 0;

            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
