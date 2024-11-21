using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{

    public abstract class Book  //define absract class
    {
        //defult is private
        string title;
        string author;
        protected double price;

        //c'tor
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        //return title name
        public string GetTitle()
        {
            return title;
        }
        //return author name
        public string GetAuthor()
        {
            return author;
        }
        //return price of the book
        public double GetPrice()
        {
            return price;
        }
        //abstract func that return the discount of the book
        public abstract double CalculateDiscount();
    }
}
