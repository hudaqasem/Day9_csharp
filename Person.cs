using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Person
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; }
        #endregion

        #region constructor
        public Person(int id, string name, Gender g, string d)
        {
            Id = id;
            Name = name;
            Gender = g;
            Department = d;
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name} , Gender : {Gender} , Department : {Department}";
        } 
        #endregion
    }
}
