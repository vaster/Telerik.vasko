using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Company
{
    //barcode, vendor, title and price

    public class Article : IComparable<Article>
    {
        public int Barcode { get; private set; }

        public string Vendor { get; private set; }

        public string Title { get; private set; }

        public int Price { get; private set; }

        public Article(int barcode, string vendor, string title, int price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            if (this.Price.CompareTo(other.Price) > 0)
            {
                return 1;
            }
            else if (this.Price.CompareTo(other.Price) < 0)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return String.Format(this.Barcode + " " + this.Vendor + " " + 
                this.Title + " " + this.Price);
        }
    }
}
