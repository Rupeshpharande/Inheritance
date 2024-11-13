using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     public class SavingAc:BankAcccount
    {
        double balance=500;

        public override void deposite(double amt)
        {
            if (amt > 0)
            {
                balance += amt;
                Console.WriteLine(amt +" deposite successful");
            }
            else
            {
                Console.WriteLine("invalid deposite amt");
            }
           
        }

        public override void Withdraw(double amt)
        {
            if (balance >= amt)
            {
                balance -= amt;
                Console.WriteLine(amt+ " Withdraw Successful" );

            }
            else
            {
                Console.WriteLine("Insuffient balance");
            }

        }

        public override string ToString()
        {
            return $"Current Balance={balance}";
        }
    }
}
