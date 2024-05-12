using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class PrintUsingThread
    {

        public void threadA()
        {
            for(var i = 0; i < 20;i++)
            {
                Console.WriteLine("printing from thread 1");
                Thread.Sleep(300);

            }
        }
        public void threadB()
        {
            for (var i = 0;i < 20;i++)
            {
                Console.WriteLine("printing from thread 2");
                Thread.Sleep(300);
            }
           

        }
        public static void thread1()
        {
            for(var i=0;i < 20;i++)
            {
                Console.WriteLine("printing thread 1");
                Thread.Sleep(500);
            }
        }
        public static void thread2()
        {
            for(int  i = 0;i < 20; i++)
            {
                Console.WriteLine("printing thread 2");
                Thread.Sleep(500);
            }
        }
    }
}
