using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = "3";
            int n = Extensions.ToInt(number);
            int n2 = number.ToInt(); // metoda rozszerzająca - > nie podajemy parametru "this"; kazdy string ma metodę toint

            int n1 = Extensions.ToInt(number);
            string z = 20.ToString();


            string text = "kasia ma psa";

            text.Log();
            try
            {
                throw new Exception("blabla");
            }
            catch (Exception exe)
            {
                exe.Message.Log();
         
            }
            Console.WriteLine(text.Left(5));
            Console.WriteLine(n);
            Console.WriteLine(n2);
            Console.Read();


        }
    }
}
