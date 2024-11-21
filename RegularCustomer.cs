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
        protected List<Book> purchasedBooks=new List<Book>();
        public RegularCustomer(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public virtual void BuyBook(Book book)//defining the func as virtual that we can override in the inheriting class
        {
            purchasedBooks.Add(book);
        }
        public List<Book> GetPurchasedBooks()
        {
            return purchasedBooks;
        }
    }
}
