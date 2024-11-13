using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class PartTimeEmp : Employees
    {
        int id;
        string name;
        int hours;

        public PartTimeEmp(int id, string name, int hours)
        {
            this.id = id;
            this.name = name;
            this.hours = hours;
        }

        public override double calsal()
        {
            return hours * 200;
        }
    }
}
