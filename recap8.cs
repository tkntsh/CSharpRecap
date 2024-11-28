using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basePay = 2000;
            double taxTaken = basePay*0.8;
            double taxPaid = basePay-taxTaken;
            double payAfterText = basePay-taxPaid;

            Console.WriteLine(payAfterText);
            Console.WriteLine(taxPaid);
        }
    }
}
