using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    public class DirTreeCreator
    {
        private string StartDirectoryPath { get; set; }

        private DirectoryInfo StartDirectory { get; set; }

        private Folder Parent { get; set; }

        private Tree Tree { get; set; }

        private Folder Root { get; set; }

        private bool ToTakeRoot { get; set; }

        public DirTreeCreator(string startDirectoryPath)
        {
            this.StartDirectoryPath = startDirectoryPath;
            this.StartDirectory = Directory.CreateDirectory(this.StartDirectoryPath);
            this.ToTakeRoot = true;
        }

        public Tree Create()
        {

            this.Root = new Folder(StartDirectory.Name);

            this.Parent = new Folder(StartDirectory.Name);

            this.Interate(this.StartDirectory,this.Root);

            this.Tree = new Tree(this.Root);

           
            return this.Tree;
        }

        private void Interate(DirectoryInfo directory, Folder child)
        {
            DirectoryInfo[] subDirectory = directory.GetDirectories();
            Folder[] treeFolder = new Folder[subDirectory.Length];
            if (child != null)
            {
                this.Parent.AddSubFolders(child);
            }


            foreach (var subDir in subDirectory)
            {
               
                child = new Folder(subDir.Name);
                try
                {
                    foreach (var file in subDir.GetFiles())
                    {
                        child.AddFiles(new File(file.Name,file.Length));
                    }
                   
                    this.Interate(subDir,child);
                    
                }
                catch(UnauthorizedAccessException)
                {

                }

                //this.Parent.AddSubFolders(new Folder(subDir.Name));
            }
           
            this.Parent.AddSubFolders(child);
        }
    }
}

