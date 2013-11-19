using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSystem
{
    public abstract class Document : IDocument
    {
        public string name;
        public string content;
        //methods
        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            if (key == "content")
            {
                this.Content = value;
            }
        }
        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }


        //properties

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
        public string Content
        {
            get { return this.content; }
            protected set { this.content = value; }
        }
    }
}
