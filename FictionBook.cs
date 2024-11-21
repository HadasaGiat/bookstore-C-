using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bookStore
{
    public class FictionBook : Book//מחלקת ספר דמיוני
    {

        string genre;

        //constractor that calling the main c'ot
        public FictionBook(string title, string author, double price, string genre) : base(title, author, price)
        {
            this.genre = genre;
        }
        //return genre
        public string GetGenre()
        {
            return genre;
        }

        //return final price of the book after discount
        public override double CalculateDiscount()
        {
            return price * 0.9;
        }
    }
}
