using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetText();
        }
        static void GetText()
        {
            try
            {
                var path = "c//myfile";
                var text = File.ReadAllText(path);
                if(!string.IsNullOrEmpty(text))
                {
                    throw new EmptyFileException("file is empty");

                }
                Console.WriteLine(text);
            }
            catch(FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
            catch(EmptyFileException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("exception found   "+ex.Message);
            }
            finally
            {
                Console.WriteLine("program ended");
            }

        }
    }
}
