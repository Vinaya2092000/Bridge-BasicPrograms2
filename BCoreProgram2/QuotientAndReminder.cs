﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCoreProgram2
{
    public class QuotientAndReminder
    {
        public void Divide()
        {
            Console.WriteLine("Enter the Divident: ");
            int divi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor: ");
            int divs = Convert.ToInt32(Console.ReadLine());

            int quotient = divi / divs;
            int remainder = divi % divs;

            Console.WriteLine("Dividend:{0} Divisor:{1}", divi, divs);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
