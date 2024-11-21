using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    class PremiumCustomer : RegularCustomer
    {
        string membershipId;
        public PremiumCustomer(string name, string membershipId) : base(name)//c'tor that runs pather c'tor
        {
            this.membershipId = membershipId;
        }
        public override void BuyBook(Book book)//override the func in the base class
        {
            Book discountedBook;//create another book with a price after discount
            double price = book.CalculateDiscount() * 0.95;//discount calculation to premium customer
            //checking what is the type of book
            if (book is FictionBook fictionBook)//if the book is fiction so save the data 
                discountedBook = new FictionBook(fictionBook.GetTitle(), fictionBook.GetAuthor(), price, fictionBook.GetGenre());
            if (book is NonFictionBook nonFictionBook)
                discountedBook = new NonFictionBook(nonFictionBook.GetTitle(), nonFictionBook.GetAuthor(), price, nonFictionBook.GetSubject());
            else discountedBook = book;

            purchasedBooks.Add(discountedBook);
        }
    }
}
