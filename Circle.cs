using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Enums
{
    struct Circle
    {
        #region properties
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region constructor
        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        #endregion

        public static bool operator ==(Circle a, Circle b)
        {
            return a.Radius == b.Radius && a.Color == b.Color;
        }

        public static bool operator !=(Circle a, Circle b)
        {
            return !(a == b);
        }

    }
}




