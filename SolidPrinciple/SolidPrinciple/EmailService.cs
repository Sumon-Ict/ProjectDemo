using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class EmailService : IEmailSystem
    {

          // output print with two precedure 
        private void ProcessEmail(string user,string subject,string body)
        {
            Console.WriteLine("using processmail method");
            Console.WriteLine($"username={user} , password={subject} , email={body}");
        }
        public void SendEmail(string receiver, string subject, string body)
        {
           
            ProcessEmail(receiver,subject,body);

            Console.WriteLine("using old email syetem");

            Console.WriteLine("recieivername="+receiver+ ",subject="+subject+",body="+body);
            
        }
    }
}
