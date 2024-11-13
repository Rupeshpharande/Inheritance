using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
       
            protected int id;
            protected string name;
            protected double basic, hra, da, pf, gross;
            private static int count;
         
            private Date date;
            public Employee(string nam, double bas, Date date)
            {
                count++;
                id = count;
                name = nam;
                basic = bas;
                this.date = date;
            }
            public virtual void CalculateSalary()
            {
                hra = basic * 0.40; 
                da = basic * 0.20;
                pf = basic * 0.12;
                gross = (basic + hra + da) - pf;
            }
           
            public override string ToString()
            {
                return $"Id = {id} , Name {name}, Gross salary ={gross},Joining Date ={date.DisplayDate()}";
            }

            // static method

            public static int EmpCount()
            {
                return count;
            }
        }

    }

