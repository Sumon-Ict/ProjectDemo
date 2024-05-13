using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class MemberShipService 
    {
        private readonly IEmailSystem _emailSystem;

        public MemberShipService(IEmailSystem emailSystem)
        {
            _emailSystem = emailSystem;
        }

        public void CreateAccount(string username, string password,string email)
        {
            _emailSystem.SendEmail(username, password, email);
        }

    }
}
