using System;
using System.IO;
using System.Security.AccessControl;

namespace DirectoryIteretion
{
    public class Interator
    {
        private DirectoryInfo StartPoint { get; set; }

        public Interator()
        {
            this.StartPoint = Directory.CreateDirectory(@"C:\WINDOWS");
        }

        public void InterateDirectory()
        {
            this.InterateDirectory(this.StartPoint);
        }

        private void InterateDirectory(DirectoryInfo path)
        {
            DirectoryInfo[] subDirectory = path.GetDirectories();
            FileInfo[] directoryFiles;

            for (int currDir = 0; currDir < subDirectory.Length; currDir++)
            {
                try
                {
                    this.InterateDirectory(subDirectory[currDir]);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(subDirectory[currDir].Name + " Not accessable!");
                }

                directoryFiles = subDirectory[currDir].GetFiles();
                for (int fileIndex = 0; fileIndex < directoryFiles.Length; fileIndex++)
                {
                    if (directoryFiles[fileIndex].Extension == ".exe")
                    {
                        Console.WriteLine(directoryFiles[fileIndex].Name);
                    }
                }
            }
        }
    }
}
