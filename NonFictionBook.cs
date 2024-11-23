using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    class NonFictionBook : Book//מחלקת ספר עיון
    {
        string subject;

        //c'tor
        public NonFictionBook(string title, string author, double price, string subject) : base(title, author, price)
        {
            this.subject = subject;
        }
        //return 5% discount for Non-Fiction books
        public override double CalculateDiscount()
        {
            return price * 0.05;
        }
    }
}
