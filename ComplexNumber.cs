using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Classes
{
    internal class ComplexNumber
    {
        #region properties
        public int Real { get; set; }
        public int Imag { get; set; }

        #endregion

        #region Method
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #endregion

        #region operator overloading
        public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
        }
        public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = Left.Real - Right.Real,
                Imag = Left.Imag - Right.Imag,
            };
        }
        public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = Left.Real * Right.Real,
                Imag = Left.Imag * Right.Imag,
            };
        } 
        #endregion

    }
}
