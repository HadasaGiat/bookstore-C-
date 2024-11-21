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

            Book nonfictionBook = new NonFictionBook("The Secret", "Rhonda Byrne", 150, "personal development");//הגדרת אובייקט ספר עיון עם מצביע מסוג האב     
            Book fictionBook = new FictionBook("Avenger", "Frederick Forsyth", 150, "Thriller");//שימוש באותו מצביע כדי להקצות אובייקט של מחלקה אחרת  

            RegularCustomer regularCustomer = new RegularCustomer("hadasa");//הגדרת אובייקט לקוח רגיל
            PremiumCustomer premiumCustomer = new PremiumCustomer("Shir", "SHir1234");//הגדרת לקוח פרימיום
            
            //קניית ספרים שונים ללקוח 
            regularCustomer.BuyBook(nonfictionBook);
            regularCustomer.BuyBook(fictionBook);

            //הצגת הלקוח ,הצגת השימת הספרים שרכש לקוח רגיל
            Console.WriteLine(regularCustomer.GetName());
            foreach (var item in regularCustomer.GetPurchasedBooks())
                Console.WriteLine($"TITLE : {item.GetTitle()} , PRICE : {item.GetPrice()} , PRICE AFTER DISCOUNT : {item.CalculateDiscount()} ");

            //קניית ספרים ללקוח פרמיום
            premiumCustomer.BuyBook(nonfictionBook);
            premiumCustomer.BuyBook(fictionBook);

            //הצגת הלקוח ,הצגת השימת הספרים שרכש לקוח פרמיום
            Console.WriteLine(premiumCustomer.GetName());
            foreach (var item in premiumCustomer.GetPurchasedBooks())
                Console.WriteLine($"TITLE : {item.GetTitle()} , PRICE : {item.GetPrice()} , PRICE AFTER DISCOUNT : {item.CalculateDiscount()} ");


        }
    }
}
