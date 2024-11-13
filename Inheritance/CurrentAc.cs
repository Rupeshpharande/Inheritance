using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CurrentAc:BankAcccount
    {
        double balance = 5000;

        public override void deposite(double amt)
        {
           if(amt>500)
            {
                balance += amt;
                Console.WriteLine(amt + " deposite successfully");
            }
            else
            {
                Console.WriteLine("invalid amt");
            }
        }

        public override void Withdraw(double amt)
        {
           if(amt<balance)
            {
                balance -= amt;
                Console.WriteLine(amt + " Withdraw successfully");
            }
            else
            {
                Console.WriteLine("Insuffient Balance");
            }
        }
        public override string ToString()
        {
            return $"Current banlance= {balance}";
        }
    }

}
