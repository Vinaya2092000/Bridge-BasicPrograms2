using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCoreProgram2
{
    public class VowelsConsonents
    {
        public void VowelCons()
        {
            char ch;

            Console.WriteLine("Enter an Alphabet : ");
            char v = Convert.ToChar(Console.ReadLine().ToLower());
            ch = v;
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is a Consonant");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}