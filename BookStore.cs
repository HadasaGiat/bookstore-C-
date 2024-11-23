using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    internal class BookStore
    {
        static void Main(string[] args)
        {
            //create books
            Book nonfictionBook = new NonFictionBook("The Secret", "Rhonda Byrne", 100, "personal development");  
            Book fictionBook = new FictionBook("Avenger", "Frederick Forsyth", 100, "Thriller");

            //create customers
            RegularCustomer regularCustomer = new RegularCustomer("hadasa");
            PremiumCustomer premiumCustomer = new PremiumCustomer("Shir", "SHir1234");

            // Regular customer buys books
            regularCustomer.BuyBook(nonfictionBook);
            regularCustomer.BuyBook(fictionBook);

           
            //display regular customer purchases
            Console.WriteLine("Regular --- " + regularCustomer.GetName());
            foreach (var item in regularCustomer.GetPurchasedBooks())
                Console.WriteLine($"TITLE : {item.GetTitle()} , AUTHOR : {item.GetAuthor()} , PRICE AFTER DISCOUNT : {item.GetPrice() - item.CalculateDiscount()} ");

            //premium coustomer buys books
            premiumCustomer.BuyBook(nonfictionBook);
            premiumCustomer.BuyBook(fictionBook);

            Console.WriteLine();

            //display premium customer purchases
            Console.WriteLine("Premium --- " + premiumCustomer.GetName());
            foreach (var item in premiumCustomer.GetPurchasedBooks())
                Console.WriteLine($"TITLE : {item.GetTitle()} , AUTHOR : {item.GetAuthor()} , PRICE AFTER DISCOUNT : {item.GetPrice()} ");


        }
    }
}
