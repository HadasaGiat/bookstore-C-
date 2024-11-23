using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    class PremiumCustomer : ICustomer
    {
        string name;
        string membershipId;
        protected List<Book> purchasedBooks;//defining a list thet save the books the customer buy
        //c'tor
        public PremiumCustomer(string name, string membershipId)
        {
            this.name = name;
            this.membershipId = membershipId;
            this.purchasedBooks = new List<Book>();
        }
        public string GetName() => name;
        public void BuyBook(Book book)
        {
            //create another book with a price after discount
            Book discountedBook = book ;

            //discount calculation to premium customer 5%
            double finalPrice = (book.GetPrice() - book.CalculateDiscount()) *0.95 ;

            if (book is FictionBook fictionBook)//if the book is fiction so save the data with genre        
                purchasedBooks.Add(new FictionBook(fictionBook.GetTitle(), fictionBook.GetAuthor(), finalPrice, fictionBook.GetTitle()));

            else if (book is NonFictionBook nonFictionBook)//if the book is non fiction so save the data with subject               
                purchasedBooks.Add(new NonFictionBook(nonFictionBook.GetTitle(), nonFictionBook.GetAuthor(), finalPrice, nonFictionBook.GetTitle()));

          
        }

        public List<Book> GetPurchasedBooks()
        {
            return purchasedBooks;
        }
    }
}
