using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            int simvol = Convert.ToInt32(Console.ReadLine());
            if (simvol >= 91 && simvol <= 100)
            {
                Console.WriteLine("qiymet=A");
            }
            else if (simvol >= 81 && simvol <= 90)
            {
                Console.WriteLine("qiymet=B");
            }
            else if (simvol >= 71 && simvol <= 80)
            {
                Console.WriteLine("qiymet=C");
            }
            else if (simvol >= 61 && simvol <= 70)
            {
                Console.WriteLine("qiymet=D");
            }
            else if (simvol >= 51 && simvol <= 60)
            {
                Console.WriteLine("qiymet=E");
            }
            else
            {
                Console.WriteLine("qiymet= kesildinnnn");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
    

