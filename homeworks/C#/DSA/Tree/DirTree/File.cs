using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    public class File
    {
        public string Name { get;private set; }

        public long Size { get;private set; }

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
