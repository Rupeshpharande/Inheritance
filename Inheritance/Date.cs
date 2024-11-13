using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   
    
        public class Date
        {

           
            private int day, year;
            private string month;
           
            public Date(int day, string month, int year=2024)
            {
                this.day = day; 
                this.month = month;
                this.year = year;
            }
            public string DisplayDate()
            {
                return $"Date is : {day} / {month} /{year}";
            }
        }

    }

