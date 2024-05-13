using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book=new Book();
            book.Id= 1;
            book.Name = "Math";
            book.cost = 122;
            book.Description = "Interesting type";
            book.Printf();

           var result= book.Discount(book);

            Console.WriteLine(result);

            var scienceB=new Science();
            scienceB.Id= 1;
            scienceB.Name = "English";
            scienceB.booktitle = "Science";
            scienceB.cost = 400;
            scienceB.Description = "ramantic";
            scienceB.Printf();
            scienceB.printf2(scienceB);
            var res= scienceB.Discount(scienceB);
            Console.WriteLine(res); 

        }
    }
}
