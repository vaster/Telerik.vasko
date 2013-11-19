using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace PointInSpace
{
    static public class PathStorage
    {

        private static StreamReader fromFile = new StreamReader("input.txt");
        private static StreamWriter toFile = new StreamWriter("output.txt");
        private static List<Point3D> pointFromFile = new List<Point3D>();
        private static Point3D tempFilePoint = new Point3D();
        private static char readSymbol = '\0';

        static private List<Point3D> readFromFile() // method to read points from file
        {
            int cordinateCounter = 0;
            StringBuilder cordinate = new StringBuilder();

            using (fromFile)
            {
                while (!fromFile.EndOfStream)
                {
                    readSymbol = (char)fromFile.Read();
                    if (readSymbol >='0' && readSymbol <='9' || readSymbol=='-' || readSymbol=='.')
                    {
                        cordinate.Append(readSymbol);
                        
                    }
                    if (readSymbol == ',' || readSymbol ==']')
                    {
                        
                        if (cordinateCounter == 0)
                        {
                            tempFilePoint.X = Convert.ToDouble(cordinate.ToString());
                            cordinate.Clear();
                        }
                        if (cordinateCounter == 1)
                        {

                            tempFilePoint.Y = Convert.ToDouble(cordinate.ToString());
                            cordinate.Clear();
                        }
                        if (cordinateCounter == 2)
                        {
                            
                            tempFilePoint.Z = Convert.ToDouble(cordinate.ToString());
                            cordinate.Clear();
                        }
                        cordinateCounter++; 
                    }
                    if (readSymbol == ']')
                    {
                        cordinateCounter = 0;
                        pointFromFile.Add(tempFilePoint);
                    }
                   
                }
                
            }

            return pointFromFile;
        }


        static public void  Save(List<Point3D> listToBeSavedInFile) //method to save points from list to a file
        {
            using (toFile)
            {
                for (int i = 0; i < listToBeSavedInFile.Capacity; i++)
                {
                    toFile.WriteLine(String.Format("[{0},{1},{2}]", listToBeSavedInFile[i].X.ToString(), listToBeSavedInFile[i].Y.ToString(), listToBeSavedInFile[i].Z.ToString()));
                }
            }
        }


        static public List<Point3D> Load() //method that invoke and return another method to return a list with points 
        {

            return readFromFile();
        }


    }
}
