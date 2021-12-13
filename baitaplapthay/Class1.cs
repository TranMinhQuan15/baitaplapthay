using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_BT1
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int a, b;
            Console.WriteLine("Cho vao a bang");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cho vao b bang");
            b=Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Error: divided by zero");
            }
            else
            {
                float c = (float)a / b;
                Console.WriteLine("c=" + c);
            }
            Console.ReadKey();
        }
          
    }
}


