using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Department
    {
        #region properties
        public int DId { get; set; }
        public string DName { get; set; }
        #endregion

        #region constructor
        public Department(int id, string name)
        {
            DId = id;
            DName = name;
        }
        #endregion

        public override bool Equals(object? obj)
        {
            Department passed = (Department)obj;
            return (
                passed.DId == this.DId && 
                passed.DName ==this.DName
                );
        }
    }
}
