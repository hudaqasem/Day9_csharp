

using Day9.Classes;
using Day9.Enums;
using System.Drawing;

namespace Day9
{
    internal class Program
    {
        #region Methods
        public static void Swap(ref Rectangle1 r1, ref Rectangle1 r2)
        {
            Rectangle1 temp = r1;
            r1 = r2;
            r2 = temp;
            //Rectangle1 Temp = new Rectangle1(r1.Length , r1.Width);
            //r1.Length = r2.Length;
            //r1.Width = r2.Width;
            //r2.Length = Temp.Length;
            //r2.Width = Temp.Width;
        }

        public static T[] Reverse<T>(T[] array)
        {
            T[] R = new T[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                R[j] = array[i];
                j++;
            }
            return R;
        }

        public static void SwapEle<T>(ref T[] array, int idx1, int idx2)
        {
            T Temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = Temp;

        }

        public static T MaxEle<T>(T[] array) where T : IComparable<T> 
        {
            T Max = array[0];
            for (int i = 0; i < array?.Length; i++)
            {
                Max = (array[i].CompareTo(Max) >= 0) ? array[i] : Max;
            }
            return Max;
        }

	#endregion
        static void Main(string[] args)
        {

            #region Enum

            //Weekdays D1 = Weekdays.Friday;
            //Console.WriteLine($"DName : {D1}");
            //Console.WriteLine($"DValue : {(int)D1}");

            //*********************************

            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"Grade: {grade}, Value: {(short)grade}");
            //}
            ////Grade: A, Value: 0
            ////Grade: B, Value: 1
            ////Grade: B, Value: 1 // GetValues=> return array of the values that in the enum
            ////Grade: C, Value: 252
            ////Grade: D, Value: 253
            ////Grade: E, Value: 254 

            //*********************************

            //Person person1 = new Person(1,"Ali",Gender.Male,"D1");
            //Person person2 = new Person(2,"Aisha",Gender.Female,"D1");
            //Console.WriteLine(person1);
            //Console.WriteLine(person2);

            #endregion

            #region sealed
            //Child child = new Child();
            //child.Salary = 10000;
            //child.DisplaySalary(); 
            #endregion

            #region  static method
            //Console.WriteLine(Utility.RectanglePerimeter(2,4)); 

            //Console.WriteLine($"77 Fahrenheit = {Utility.FahrenheitToCelsius(77)} Celsius");
            //Console.WriteLine($"25 Celsius = {Utility.CelsiusToFahrenheit(25)} Fahrenheit");

            #endregion

            #region operator overloading
            //ComplexNumber Num1 = new ComplexNumber() { Real = 4 , Imag = 2};
            //ComplexNumber Num2 = new ComplexNumber() { Real = 3 , Imag = 6};
            //ComplexNumber Result = Num1 * Num2;
            //Console.WriteLine($"({Num1}) * ({Num2}) = {Result}"); 
            #endregion

            #region byteEnum
            //Gender M1 = Gender.Male;
            //GenderByte M2 = GenderByte.Male;
            //Console.WriteLine($"Gender int : {M1} , value : {(int)M1}");
            //Console.WriteLine($"Gender byte: {M2} , value : {(byte)M2}");
            //Console.WriteLine("Memory : ");
            //Console.WriteLine($"Gender byte = {sizeof(Byte)} byte");
            //Console.WriteLine($"Gender int = {sizeof(int)} byte"); 
            #endregion

            #region Enum.parse
            //Grades G;
            //do
            //{
            //    Console.Write("Enter Invalid Grade (A, B, C, D, E, F): ");
            //} while (!Enum.TryParse(Console.ReadLine() , out G));

            //Console.WriteLine($"Grade : {G} , value : {(short)G}"); 
            #endregion

            #region SearchArr
            //Employee[] Emps = {
            //    new Employee(1,"Ali",55000),
            //    new Employee(2,"Aisha",65000),
            //    new Employee(3,"Soly",25000),
            //    new Employee(4,"Nader",95000)
            //};
            //Employee EmpS = new Employee(3, "Soly", 25000);
            //int idx = Helper2<Employee>.SearchArr(Emps,EmpS);

            //if(idx == -1)
            //    Console.WriteLine($"{EmpS} => Not found ");
            //else
            //    Console.WriteLine($"{EmpS} => found at index : {idx}"); 
            #endregion

            #region Max Value || Generic constrain
            //int X = 5 ; 
            //int Y = 6;
            //Console.WriteLine($"({X} , {Y}) Max value is : {Helper2<int>.Max(X,Y) }");

            //double A = 7.8; 
            //double B = 6.5;
            //Console.WriteLine($"({A} , {B}) Max value is : {Helper2<double>.Max(A, B)}");

            //string S = "ABC";
            //string G = "ABD";
            //Console.WriteLine($"({S} , {G}) Max value is : {Helper2<string>.Max(S, G)}"); 
            #endregion

            #region ReplaceArray
            //int[] Arr1 = { 1, 2, 3, 1, 4 , 1};
            //Helper2<int>.ReplaceArray(Arr1, 1, 10);
            //foreach (int i in Arr1)
            //    Console.Write($"{i} ");

            //Console.WriteLine();

            //string[] Arr2 = { "Ali", "Huda", "Ali", "Nada", "Ali" };
            //Helper2<string>.ReplaceArray(Arr2, "Ali", "Omar");
            //foreach (string i in Arr2)
            //    Console.Write($"{i} ");

            #endregion

            #region non-generic Swap
            //Rectangle1 R1 = new Rectangle1(1 , 2);
            //Rectangle1 R2 = new Rectangle1(3 , 4);

            //Console.WriteLine("Before swap :");
            //Console.WriteLine($"R1 : {R1}");
            //Console.WriteLine($"R2 : {R2}");

            //Swap(ref R1,ref R2);
            //Console.WriteLine("After swap :");
            //Console.WriteLine($"R1 : {R1}");
            //Console.WriteLine($"R2 : {R2}"); 
            #endregion

            #region SearchArr__2
            //Department D1 = new Department(1 , "D1");
            //Department D2 = new Department(2 , "D2");
            //Department D3 = new Department(3 , "D3");

            //Employee[] Emps = {
            //    new Employee("Ali",D1),
            //    new Employee("Aisha",D2),
            //    new Employee("Soly",D3),
            //    new Employee("Nader",D1)
            //};
            //Employee EDSearch = new Employee("Nader", D1);
            //int idx = Helper2<Employee>.SearchArr(Emps, EDSearch);

            //if (idx == -1)
            //    Console.WriteLine($"{EDSearch.Name} , {EDSearch.Dept.DName} => Not found ");
            //else
            //    Console.WriteLine($"{EDSearch.Name} , {EDSearch.Dept.DName} => found at index : {idx}"); 
            #endregion

            #region == VS Equals
            //Circle circle1 = new Circle(2,"Red");
            //Circle circle2 = new Circle(4,"Blue");
            //Circle circle3 = new Circle(4,"Blue");

            //Console.WriteLine($"== operator : {circle1==circle2}");
            //Console.WriteLine($"equals : {circle2.Equals(circle3)}");

            //CircleClass CC1 = new CircleClass(1 , "Green");
            //CircleClass CC2 = new CircleClass(2 , "Black");
            //CircleClass CC3 = new CircleClass(2 , "Black");
            //CircleClass CC4 = CC1 ;

            //Console.WriteLine($"== operator : {CC1 == CC2}"); // compare references
            //Console.WriteLine($"== ref : {CC4 == CC1}");
            //Console.WriteLine($"equals : {CC2.Equals(CC3)}");

            #endregion

            #region Reverse
            //int[] Arr1 = { 1, 2, 3, 4 };

            //Console.WriteLine("Before Reverse : ");
            //foreach (var item in Arr1)
            //{
            //    Console.Write($"{item} ");
            //}
            //int[] RArr1 = Reverse(Arr1);
            //Console.WriteLine("\nAfter Reverse : ");
            //foreach (var item in RArr1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n*****************************");
            //Employee[] Emps = {
            //    new Employee(1,"Ali",55000),
            //    new Employee(2,"Aisha",65000),
            //    new Employee(3,"Soly",25000),
            //    new Employee(4,"Nader",95000)
            //};
            //Console.WriteLine("Before Reverse : ");
            //foreach (var item in Emps)
            //{
            //    Console.WriteLine(item);
            //}

            //Employee[] REmps = Reverse(Emps);
            //Console.WriteLine("After Reverse : ");
            //foreach (var item in REmps)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region StackClass
            //GStack<int> Stack1 = new GStack<int>(3);
            //Stack1.Push(5);
            //Stack1.Push(8);
            //Stack1.Push(2);
            //Console.WriteLine(Stack1.Peek()); //2
            //Console.WriteLine($"{Stack1.Pop()} this element is ramoved");
            //Console.WriteLine(Stack1.Peek());//8 
            #endregion

            #region swap elements
            //int[] Arr1 = { 1, 2, 3, 4 };
            //SwapEle(ref Arr1, 0, 1);
            //Console.WriteLine("After Swapping : ");
            //foreach (var item in Arr1)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region MaxElement
            //double[] Arr1 = { 4.5, 2.8, 20.4, 4.2 };
            //Console.WriteLine(MaxEle(Arr1)); 
            #endregion








        }
    }
}
