using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_JavaToCSharp
{
    class BankCharges
    {
        // Creating all the class fields.
        private static readonly int baseCharge = 10;
        private static readonly int extraCharge = 15;
        private double balance = 0;
        private double bankFees = 0;
        private double checkFees = 0;
        private int checks = 0;

        // Constructors
        public BankCharges() { }

        public BankCharges(double b, int c)
        {
            balance = b;
            checks = c;
        }

        // GetFees method for calculations
        public double GetFees()
        {
            if(checks < 20)
            {
                checkFees = .10;
            }
            else if(checks >= 20 && checks <= 39)
            {
                checkFees = .08;
            }
            else if(checks >= 40 && checks <= 59)
            {
                checkFees = .06;
            }
            else
            {
                checkFees = .04;
            }
            // If balance is less than 400;
            if(balance < 400)
            {
                bankFees = baseCharge + extraCharge + (checkFees * checks);
            }
            else
            {
                bankFees = baseCharge + (checkFees * checks); // Account balance > 400;
            }
            // return the fees price.
            return bankFees;
        }

    }
}
