using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    class RegularCustomer:ICustomer
    {
        string name;
        protected List<Book> purchasedBooks;//defining a list thet save the books the customer buy
        //c'tor
        public RegularCustomer(string name)
        {
            this.name = name;
            this.purchasedBooks = new List<Book>();
        }
        public string GetName() => name;
        public void BuyBook(Book book)
        {
            purchasedBooks.Add(book);
        }
        public List<Book> GetPurchasedBooks()
        {
            return purchasedBooks;
        }
    }
}
