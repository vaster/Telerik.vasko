using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    public class Folder : IEnumerable
    {
        public string Name { get; private set; }

        public List<Folder> SubFolders { get; private set; }

        public List<File> Files { get; private set; }

        public Folder Parent { get; set; }

        public Folder(string name)
        {
            this.SubFolders = new List<Folder>();
            this.Files = new List<File>();
            this.Name = name;
            this.Parent = null;
        }

        public void AddFiles(File files)
        {
            this.Files.Add(files);
        }

        public void AddSubFolders(Folder subFolders)
        {
            this.SubFolders.Add(subFolders);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Folder f in this.SubFolders)
            {
                yield return f;
            }
        }
    }
}
