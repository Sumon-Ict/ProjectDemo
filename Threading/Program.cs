using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //with static method 
               var a = new Thread(PrintUsingThread.thread1);
               var b=new Thread(PrintUsingThread.thread2);
               a.Start();
               b.Start();

            //without static method 
            var ob = new PrintUsingThread();

            var th1 = new Thread(new ThreadStart(ob.threadA));
            var th2= new Thread(new ThreadStart(ob.threadB)); 
            
            th1.Start();
            th2.Start();





        }
    }
}
