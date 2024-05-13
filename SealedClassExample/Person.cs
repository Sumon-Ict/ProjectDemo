using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal  sealed class Person
    {

        //here all property and method are sealed so property
        //and method will not inheritance and overriding 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double cost { get; set; }

        public void printf()
        {
            Console.WriteLine("the description of the person");

            Console.WriteLine($"personId= {Id}, Name={Name},Address={Address} ");

        }

        public  double discount( Person person )
        {
            double d = (person.cost) * 15 / 100;
            return d;

        }



    }
}
