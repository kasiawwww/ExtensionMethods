using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        class Roman
        {
            public int MyProperty { get; set; }
        }
        static void Main(string[] args)
        {

            string number = "3";
            double num = 56.14;
            int n = Extensions.ToInt(number);
            int n2 = number.ToInt(); // metoda rozszerzająca - > nie podajemy parametru "this"; kazdy string ma metodę toint

            int n3 = number.ToInt();
            int n4 = num.ToInt<double>();
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

            Console.WriteLine("---------------");
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.Read();


        }
    }
}
