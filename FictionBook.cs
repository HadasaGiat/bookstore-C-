using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bookStore
{
    public class FictionBook : Book//מחלקת ספר דמיוני
    {

        string genre;

        //constractor that calling the main c'tor
        public FictionBook(string title, string author, double price, string genre) : base(title, author, price)
        {
            this.genre = genre;
        }
        //return 10% discount for Fiction books
        public override double CalculateDiscount()
        {
            return price * 0.10;
        }
    }
}
