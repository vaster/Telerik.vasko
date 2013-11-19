using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Walk
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

            Program.InitilizaMatrixes(matrixes);

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

        public static int Perform3DWalk(List<Cube[,]> layers)
        {
            int sum = 0;
            int layerIndex = 0;
            int startRow = 0;
            int startCol = 0;

            Program.InitilizeStart(layers, out startRow, out startCol, out layerIndex);

            layers[layerIndex][startRow, startCol].IsVisited = true;
            Cube curr = layers[layerIndex][startRow, startCol];
            curr.IsVisited = true;
            sum = sum + curr.Value;

            do
            {
                curr = Program.FindNextBestCube(layers, curr.LayerIndex, curr.Row, curr.Col);
                if (!curr.IsVisited)
                {
                    sum = sum + curr.Value;
                    layers[curr.LayerIndex][curr.Row, curr.Col].IsVisited = true;
                }
            } while (!curr.IsVisited);


            return sum;
        }


        public static void InitilizeStart(List<Cube[,]> layers, out int startRow, out int startCol, out int layerIndex)
        {
            if (layers.Count > 1)
            {
                layerIndex = (layers.Count / 2);
            }
            else
            {
                layerIndex = 0;
            }
            startRow = (Program.HEIGHT / 2);
            startCol = (Program.WIDTH / 2);
        }


        public static Cube FindNextBestCube(List<Cube[,]> layers, int layerIndex, int startRow, int startCol)
        {
            Cube best = new Cube() { Value = int.MinValue };
            Cube up = Program.GoUp(layers[layerIndex], startRow, startCol);
            Cube down = Program.GoDown(layers[layerIndex], startRow, startCol);
            Cube left = Program.GoLeft(layers[layerIndex], startRow, startCol);
            Cube right = Program.GoRight(layers[layerIndex], startRow, startCol);
            Cube shallow = Program.GoShallow(layers, startRow, startCol, layerIndex);
            Cube deeper = Program.GoDeeper(layers, startRow, startCol, layerIndex);

            bool areEqual = false;

            if (best.Value <= up.Value)
            {
                best = up;
            }

            if (best.Value <= down.Value)
            {
                best = down;
            }
            if (best.Value <= left.Value)
            {
                best = left;
            }
            if (best.Value <= right.Value)
            {
                best = right;
            }
            if (best.Value <= shallow.Value)
            {
                best = shallow;
            }
            if (best.Value <= deeper.Value)
            {
                best = deeper;
            }

            //////////////////

            if (best.Value == up.Value && (best.Row != up.Row && best.Col != up.Col))
            {
                areEqual = true;
            }

            if (best.Value == down.Value && (best.Row != down.Row && best.Col != down.Col))
            {
                areEqual = true;
            }
            if (best.Value == left.Value && (best.Row != left.Row && best.Col != left.Col))
            {
                areEqual = true;
            }
            if (best.Value == right.Value && (best.Row != right.Row && best.Col != right.Col))
            {
                areEqual = true;
            }
            if (best.Value == shallow.Value && (best.Row != shallow.Row && best.Col != shallow.Col))
            {
                areEqual = true;
            }
            if (best.Value == deeper.Value && (best.Row != deeper.Row && best.Col != deeper.Col))
            {
                areEqual = true;
            }

            if (areEqual)
            {
                best.IsVisited = true;
            }

            return best;
        }

        public static Cube GoUp(Cube[,] layer, int startRow, int startCol)
        {
            int max = int.MinValue;
            Cube best = new Cube() { Value = int.MinValue };

            for (int row = startRow; row > 0; row--)
            {
                if (layer[row - 1, startCol].Value >= best.Value)
                {
                    best = layer[row - 1, startCol];
                }
            }

            return best;
        }

        public static Cube GoDown(Cube[,] layer, int startRow, int startCol)
        {
            Cube best = new Cube() { Value = int.MinValue };

            for (int row = startRow; row < Program.HEIGHT - 1; row++)
            {
                if (layer[row + 1, startCol].Value >= best.Value)
                {
                    best = layer[row + 1, startCol];
                }
            }

            return best;
        }

        public static Cube GoLeft(Cube[,] layer, int startRow, int startCol)
        {
            Cube best = new Cube() { Value = int.MinValue };

            for (int col = startCol; col > 0; col--)
            {
                if (layer[startRow, col - 1].Value >= best.Value)
                {
                    best = layer[startRow, col - 1];
                }
            }

            return best;
        }

        public static Cube GoRight(Cube[,] layer, int startRow, int startCol)
        {
            Cube best = new Cube() { Value = int.MinValue };

            for (int col = startCol; col < Program.WIDTH - 1; col++)
            {
                if (layer[startRow, col + 1].Value >= best.Value)
                {
                    best = layer[startRow, col + 1];
                }
            }

            return best;
        }

        public static Cube GoDeeper(List<Cube[,]> layers, int startRow, int startCol, int layerIndex)
        {
            Cube best = new Cube() { Value = int.MinValue };

            for (int currLayer = layerIndex + 1; currLayer <= layers.Count - 1; currLayer++)
            {
                if (layers[currLayer][startRow, startCol].Value >= best.Value

                    )
                {
                    best = layers[currLayer][startRow, startCol];
                }
            }

            return best;
        }

        public static Cube GoShallow(List<Cube[,]> layers, int startRow, int startCol, int layerIndex)
        {
            Cube best = new Cube() { Value = int.MinValue };

            for (int currLayer = layerIndex - 1; currLayer >= 0; currLayer--)
            {
                if (layers[currLayer][startRow, startCol].Value >= best.Value
                    )
                {
                    best = layers[currLayer][startRow, startCol];
                }
            }

            return best;
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

        static void Main(string[] args)
        {
            List<Cube[,]> matrixes = new List<Cube[,]>();
            Program.ReadInput(matrixes);
            int sum = Program.Perform3DWalk(matrixes);

            Console.WriteLine(sum);
        }
    }
}
