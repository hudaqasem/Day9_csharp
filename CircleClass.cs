using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Classes
{
    internal class CircleClass
    {
        #region properties
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region constructor
        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        #endregion

        public override bool Equals(object? obj)
        {
            CircleClass passed = (CircleClass)obj;
            return( passed.Radius == this.Radius && passed.Color == this.Color);
        }


    }
}
