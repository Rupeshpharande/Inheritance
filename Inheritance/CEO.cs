using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CEO : Employee
    {
        private string address;
        private double bonus;

        public CEO(string nam, double bas, Date date,string address,double bonus) : base(nam, bas, date)
        {
            this.address = address;
            this.bonus = bonus;
        }
        public override void CalculateSalary()
        {
            hra = basic * 0.20;
            da = basic * 0.10;
            pf = basic * 0.5;
            gross = (basic + hra + da+bonus) - pf;
        }
        public override string ToString()
        {
            return $"CEO details:- Id = {id} , Name {name}, Gross salary ={gross}";
        }

    }
}
