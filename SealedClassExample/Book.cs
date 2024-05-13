using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Book
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double cost { get; set; }

        public void Printf()
        { 
           Console.WriteLine($"book id={Id}, name={Name},Description={Description}, cost={cost}");
        }

        public  virtual double Discount(Book book)
        {
            double r=(book.cost)*12/100;
            return r;

        }

    }
}
