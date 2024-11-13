using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Date dd = new Date(24, "Jan", 2024);

            //Employee emp = new Employee("Shivam", 30000, dd);
            //emp.CalculateSalary();
            //Console.WriteLine(emp);



            //Employee emp1 = new Employee("Akshay", 60000, new Date(2, "june", 2024));
            //emp1.CalculateSalary();
            //Console.WriteLine(emp1);


            //CEO c = new CEO("Rohan", 34000, dd,"Pune",4000);
            //c.CalculateSalary();
            //Console.WriteLine(c);

            //Employee emp2 = new CEO("Rupesh", 53000, dd,"pune",4000);
            //emp2.CalculateSalary(); 
            //Console.WriteLine(emp2);


            //Rectangle r = new Rectangle(5.6,7.4);
            //Console.WriteLine(r.CalculateArea());

            //SavingAc s=new SavingAc();
            // s.deposite(6000.0);
            //s.Withdraw(2000);
            //Console.WriteLine(s.ToString());
            //Console.WriteLine();

            //CurrentAc c=new CurrentAc();
            //c.deposite(7000);
            //c.Withdraw(17000);
            //Console.WriteLine(c.ToString());

            // Circle c = new Circle(5);
            //Console.WriteLine("area= "+ c.CalculateArea());
            //Console.WriteLine("perimeter= " +c.Perimeter());
            // Console.WriteLine();

            // Triangle t = new Triangle(5, 7);
            // Triangle t1=new Triangle(10,15,10);
            // Console.WriteLine("Area of Triangle=" + t.CalculateArea());
            // Console.WriteLine("Perimeter of Triangle=" +t1.Perimeter());

            //PartTimeEmp pt = new PartTimeEmp(1,"Rupesh",40);
            //Console.WriteLine("Part time Emp:" +pt.calsal());
            //FullTime ft = new FullTime(2, "Rohan", 90);
            //Console.WriteLine("full time Emp=" +ft.calsal());

            Iflyable s = new SpaceCraft();
            Iflyable a = new Airplane();
            Iflyable h=new Helicopter();

            s.Flyobj();
            a.Flyobj();
            h.Flyobj();


        }
    }
}
