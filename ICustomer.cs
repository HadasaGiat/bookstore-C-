using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    interface ICustomer
    {
        string GetName();//return the cusromer name
        void BuyBook(Book book);//save the book on the list
        List<Book> GetPurchasedBooks();// returns the list of purchased books

    }
}
