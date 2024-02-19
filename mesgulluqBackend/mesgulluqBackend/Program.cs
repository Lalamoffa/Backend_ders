using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesgulluqBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simvol daxil edin:");
            char k = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());
           


            if (k == '-')
            {
                if (a < b)
                {
                    Console.WriteLine("netice: " + (b - a));
                }
            }
            else if (k == '+')
            {
                Console.WriteLine("netice: " + a + b);
            }
            else if (k == '*')
            {
                Console.WriteLine("netice: " + a * b);
            }

            else if (k == '%')
            {
                Console.WriteLine("netice: " + a % b);
            }

            else if (k == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("0-a bolme emeli yoxdur. 0-dan ferqli eded daxil edin ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("netice: " + a / b);
                }


                else
                {
                    Console.WriteLine("netice: " + a / b);
                }

            }

        }
    }
}
