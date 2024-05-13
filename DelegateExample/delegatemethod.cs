using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class delegatemethod
    {
        public void multiplication(int x,int y)
        {
            Console.WriteLine($"multiplication of two number is {x * y}");

        }
        public void division(int  x,int y) 
        {
            Console.WriteLine($"the division result is {x/y}");
        }
    }
}
