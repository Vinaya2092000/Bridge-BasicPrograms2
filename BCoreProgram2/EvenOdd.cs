using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCoreProgram2
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write(num + " is an even number.");
            }
            else if (num % 2 == 1)
            {
                Console.Write(num + " is an odd number.");
            }
        }
    }
}
