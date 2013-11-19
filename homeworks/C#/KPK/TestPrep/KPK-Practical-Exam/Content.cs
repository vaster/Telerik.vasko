using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    [ExcludeFromCodeCoverage]
    public class Content : IComparable, IContent
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        public string TextRepresentation { get; set; }

        public CatalogItem Type { get; set; }

        private string url;

        public Content(CatalogItem type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ItemInformation.Title];
            this.Author = commandParams[(int)ItemInformation.Author];
            this.Size = Int64.Parse(commandParams[(int)ItemInformation.Size]);
            this.URL = commandParams[(int)ItemInformation.Url]; 
        }

        public int CompareTo(object content)
        {
            IContent contentToCompare = content as Content;

            if (contentToCompare == null)
            {
                throw new NullReferenceException();
            }
           
            else
            {
                Int32 comparisonResult = this.TextRepresentation.CompareTo(contentToCompare.TextRepresentation);

                return comparisonResult;
            }

            throw new ArgumentException("Object is not a Content");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.URL);

            return output;
        }

        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString();
            }
        }
    }
}
