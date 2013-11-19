using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    public class Sumator
    {

        private Folder Root { get; set; }
        
        private BigInteger Sum { get; set; }

        public Sumator(Tree tree, string startFolderName)
        {
            if (tree.Root.Name == "a")
            {
                this.Root = tree.Root;
            }
            else
            {
                foreach (var folder in tree.Root.SubFolders)
                {
                    if (folder.Name == "a")
                    {
                        this.Root = folder;
                        break;
                    }
                }
            }
        }

        public BigInteger GetSum()
        {
            this.MakeSum(this.Root);
            this.Sum = 0;

            return this.Sum;
        }

        private void MakeSum(Folder root)
        {
            List<Folder> subDirectory = root.SubFolders;
            if (subDirectory == null)
            {
                subDirectory[0] = root;
            }
            List<File> directoryFiles;

            for (int currDir = 0; currDir < subDirectory.Count; currDir++)
            {

                directoryFiles = subDirectory[currDir].Files;
                for (int fileIndex = 0; fileIndex < directoryFiles.Count; fileIndex++)
                {
                    this.Sum = this.Sum + directoryFiles[fileIndex].Size;
                }
                this.MakeSum(subDirectory[currDir]);
            }
        }
    }
}
