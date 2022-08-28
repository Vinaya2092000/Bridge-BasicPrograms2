namespace BCoreProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Quotient and Reminder");
            Console.WriteLine("Enter 2 for Swap Numbers");
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
            }
        }
    }
}