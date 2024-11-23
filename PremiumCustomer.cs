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

            // calculate the regular discount
            double discount = book.CalculateDiscount();
            double priceAfterDiscount = book.GetPrice() - discount;

            //discount calculation to premium customer 5%
            double finalPrice = priceAfterDiscount * 0.95;

            //if the book is fiction so create a new book with the final price
            if (book is FictionBook fictionBook)     
                purchasedBooks.Add(new FictionBook(fictionBook.GetTitle(), fictionBook.GetAuthor(), finalPrice, fictionBook.GetTitle()));

            //check if the book is non fiction         
            else if (book is NonFictionBook nonFictionBook)     
                purchasedBooks.Add(new NonFictionBook(nonFictionBook.GetTitle(), nonFictionBook.GetAuthor(), finalPrice, nonFictionBook.GetTitle()));

          
        }

        public List<Book> GetPurchasedBooks()
        {
            return purchasedBooks;
        }
    }
}
