namespace BCoreProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Quotient and Reminder");
            Console.WriteLine("Enter 2 for Swap Numbers");
            Console.WriteLine("Enter 3 for Even or Odd");
            Console.WriteLine("Enter 4 for Vowels or Consonents");
            int sh = Convert.ToInt32(Console.ReadLine());
            NewMethod(sh);
        }

        private static void NewMethod(int sh)
        {
            switch (sh)
            {
                case 1:
                    QuotientAndReminder qar = new QuotientAndReminder();
                    qar.Divide();
                    break;
                case 2:
                    SwapNumbers swap = new SwapNumbers();
                    swap.SNumbers();
                    break;
                case 3:
                    EvenOdd eo = new EvenOdd();
                    eo.EvenOrOdd();
                    break;
                case 4:
                    VowelsConsonents vc = new VowelsConsonents();
                    vc.VowelCons();
                    break;
                case 5:
                    LargestNumber largest = new LargestNumber();
                    largest.Three();
                    break;
            }
        }
    }
}