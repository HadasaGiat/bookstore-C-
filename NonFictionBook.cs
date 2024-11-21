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
        public string GetSubject()
        {
            return subject;
        }

        public override double CalculateDiscount()
        {
            return price * 0.95;
        }
    }
}
