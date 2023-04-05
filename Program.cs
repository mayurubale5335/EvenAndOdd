using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
     class Program
    {
        static void Main(string[] args)
        {
            int num = 8;

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadLine();


        }
    }
}
