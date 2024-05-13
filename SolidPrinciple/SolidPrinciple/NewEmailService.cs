using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class NewEmailService : IEmailSystem
    {
       /* private void ProcessEmail(string email,string subject,string body)
        {
            Console.WriteLine("new email system");


        }*/

       private void usermethod(string user)
        {
            Console.WriteLine("the user name of the mail  " + user);
        }

        public void SendEmail(string receiver, string subject, string body)
        {
            // ProcessEmail(receiver,subject,body); 
            //printvalue without processmail method
            Console.WriteLine("using new email system ");
           
            Console.WriteLine($"receivername={receiver}, subject={subject}, body={body}");

            usermethod(receiver); //value passed inother method


        }
    }
}
