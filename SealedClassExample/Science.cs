using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Science : Book

    {
        public string booktitle {  get; set; }

        public void printf()
        { 
            Console.WriteLine(booktitle);
        }

        
        public sealed override double Discount(Book book) // this method will not be override cause sealed
        {
            double r = (book.cost) * 30 / 100;
            return r;
        }
    }
}
