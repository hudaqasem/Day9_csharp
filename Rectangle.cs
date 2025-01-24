using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    struct Rectangle1
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public Rectangle1(int l , int w)
        {
            Length = l;
            Width = w;
        }
        public override string ToString()
        {
            return $"Length : {Length} , Width : {Width}";
        }
    }
}
