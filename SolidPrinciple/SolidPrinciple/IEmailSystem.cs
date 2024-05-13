using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal interface IEmailSystem
    {
        void SendEmail(string receiver, string subject, string body);

    }
}
