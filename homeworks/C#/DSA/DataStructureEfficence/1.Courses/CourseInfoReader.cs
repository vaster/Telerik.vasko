using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructureEfficence
{
    public class CourseInfoReader
    {
        public List<string> FirstNames { get; private set; }

        public List<string> LastNames { get; private set; }

        public List<string> CourseNames { get; private set; }

        public int StudentsCount { get; private set; }

        private TextReader Reader { get; set; }

        public CourseInfoReader(string source)
        {
            this.Reader = new StreamReader(source);
            this.FirstNames = new List<string>();
            this.LastNames = new List<string>();
            this.CourseNames = new List<string>();
            this.StudentsCount = 0;
        }

        public void ReadInfo()
        {
            const int INFO_ITEM_COUNT = 3;
            const char SEPARATOR_SYMBOL = '|';

            string line = "";
            string[] information = new string[INFO_ITEM_COUNT];

            while (line != null)
            {
                line = this.Reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                information = line.Split(SEPARATOR_SYMBOL);

                this.FirstNames.Add(information[0].Trim());
                this.LastNames.Add(information[1].Trim());
                this.CourseNames.Add(information[2].Trim());

                this.StudentsCount++;
            }
        }
    }
}
