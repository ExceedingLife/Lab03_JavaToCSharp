using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_JavaToCSharp
{
    class Program
    {
        // BankChargesDemo Program.
        static void Main(string[] args)
        {
            int checks = 0;     //Number of checks written.
            double balance = 0; //Account balance.

            // Get the account balance.
            Console.WriteLine("What is the starting account balance? ");
            string input0 = Console.ReadLine();
            try
            {                
                balance = Convert.ToDouble(input0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User input must be a number.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(-1);
            }

            // Get the number of checks written.
            Console.WriteLine("How many checks were written? ");
            string input1 = Console.ReadLine();
            try
            {
                checks = Convert.ToInt32(input1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User input must be a number.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(-1);
            }

            // Create a BankCharges object.
            BankCharges bc = new BankCharges(balance, checks);

            // Display the fees.
            Console.WriteLine("Bank fees: " + bc.GetFees().ToString("C"));
            Console.ReadLine();
        }
    }
}
