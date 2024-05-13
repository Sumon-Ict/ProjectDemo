using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email=new EmailService();
            var newmail=new NewEmailService();

            //var membership = new MemberShipService(email);
            var membership=new MemberShipService(newmail);


            membership.CreateAccount("sumon", "234", "sumon@gmail.com");
            membership.CreateAccount("masuma", "1234", "sumi@gamil.com");




        }
    }
}
