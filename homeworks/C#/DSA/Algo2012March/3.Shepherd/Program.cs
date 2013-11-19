using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Shepherd
{
    public class Logic
    {
        private List<double[,]> wallsX;
        private List<double[,]> wallsY;

        public Logic()
        {
            this.wallsX = new List<double[,]>();
            this.wallsY = new List<double[,]>();
        }

        public void AddX(double[,] x)
        {
            this.wallsX.Add(x);
        }

        public void AddY(double[,] y)
        {
            this.wallsY.Add(y);
        }

        public bool IsIn(double x, double y)
        {
            bool byX = true;
            bool byY = true;

            foreach (var item in this.wallsX)
            {
                if (item[0, 0] >= item[0, 1])
                {
                    if (x >= item[0, 0])
                    {
                        byX = false;
                    }
                    if (x <= item[0, 1])
                    {
                        byX = false;
                    }
                }

                if (item[0, 0] < item[0, 1])
                {
                    if (x <= item[0, 0])
                    {
                        byX = false;
                    }
                    if (x >= item[0, 1])
                    {
                        byX = false;
                    }
                }
            }

            foreach (var item in this.wallsY)
            {
                if (item[0, 0] >= item[0, 1])
                {
                    if (y >= item[0, 0])
                    {
                        byY = false;
                    }
                    if (y <= item[0, 1])
                    {
                        byY = false;
                    }
                }

                if (item[0, 0] < item[0, 1])
                {
                    if (y <= item[0, 0])
                    {
                        byY = false;
                    }
                    if (y >= item[0, 1])
                    {
                        byY = false;
                    }
                }
            }

            return byX && byY;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            string[] wallAndSheepCount = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            int walls = int.Parse(wallAndSheepCount[0]);
            int sheep = int.Parse(wallAndSheepCount[1]);
            Logic logic = new Logic();


            for (int i = 0; i < walls; i++)
            {
                string[] wallCoord = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double x1 = double.Parse(wallCoord[0]);
                double y1 = double.Parse(wallCoord[1]);
                double x2 = double.Parse(wallCoord[2]);
                double y2 = double.Parse(wallCoord[3]);

                logic.AddX(new double[1, 2] { { x1, x2 } });
                logic.AddY(new double[1, 2] { { y1, y2 } });
            }

            for (int i = 0; i < sheep; i++)
            {
                string sheepCoord = Console.ReadLine();
                string[] ax = sheepCoord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double x = double.Parse(ax[0]);
                double y = double.Parse(ax[1]);

                if (logic.IsIn(x, y))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
