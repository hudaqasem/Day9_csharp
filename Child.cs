using Day9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Child : Parent
    {
        public override sealed int Salary 
        {
            get { return base.Salary; } 
            set { base.Salary = value +500; } 
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
