using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Program
    {

        public delegate void addsum(int x, int y);
        public delegate void subtract(int x, int y);
        public delegate void twonum(int x, int y);

        public delegate void description(string name, string home);


        public void sum(int x, int y)

        {
            Console.WriteLine($"the sum of the two number is {x + y}");

        }
        public void sub(int x, int y)
        {
            Console.WriteLine($"the subtraction of two number is {x - y}");

        }  
        public void detail(string n, string h)
        {
            Console.WriteLine("person name =" + n);
            Console.WriteLine("person home =" + h);

        }

        static void Main(string[] args)
        {
           Program ob = new Program();

            addsum dele_ob = new addsum(ob.sum);
            subtract dele_ob2 = new subtract(ob.sub);
            description dd = new description(ob.detail);


            dele_ob(12, 45);
            dele_ob2(34, 21);
            dd("sumon", "home");

            delegatemethod ddmethod = new delegatemethod();
            twonum obtwo = new twonum(ddmethod.division);
            obtwo(20, 2);

            twonum ob3 = new twonum(ddmethod.multiplication);
            ob3(12, 34);




            

        }
    }
}
