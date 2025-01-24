using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Employee
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Department Dept { get; set; }
        #endregion

        #region constructors
        public Employee(int id, string name, double sal)
        {
            Id = id;
            Name = name;
            Salary = sal;
        }
        public Employee(string name, Department d)
        {
            Name = name;
            Dept = d;
        }
        #endregion

        #region Methods
        public override bool Equals(object? obj)
        {
            Employee passed = (Employee)obj;
            return (
                passed.Id == this.Id &&
                passed.Name == this.Name &&
                passed.Salary == this.Salary&&
                Dept.Equals(passed.Dept)
                );
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Salary : {Salary}";
        }
        #endregion
    }
}
