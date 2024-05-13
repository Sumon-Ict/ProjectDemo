using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class EmptyFileException : Exception
    {
        public EmptyFileException(string messsage):base(messsage) 
        {
        
        }
    }
}
