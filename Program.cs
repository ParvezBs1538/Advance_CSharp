using System;
namespace Advance_CSharp
{
    internal class Program
    {
        public delegate void Calculator<T, U>(T num1, U num2); 
        // <T,U> means its can contains two difference or same type parameter
        static void Main(string[] args)
        {
            //Calculator<int, float> calculate = Add;
            //Calculator<int, float> calculate = new Calculator<int, float>(Add<int, float>);
            Calculator<int,float> calculate = (x, y) => Add(x, y);

            // calculate sum
            //calculate.Invoke(40, 12.5f);
            calculate = Add<int, float>;
            calculate(40, 12.5f);

            // calculate sub
            calculate = Sub<int, float>;
            calculate(40, 20.5f);
        }
        public static void Add<T, U>(T firstNumber, U secondNumber)
        {
            dynamic n1 = firstNumber, n2 = secondNumber;
            var ans = n1 + n2;
            Console.WriteLine("Sum of the result is {0}", ans);
        }
        public static void Sub<T, U>(T firstNumber, U secondNumber)
        {
            dynamic n1 = firstNumber, n2 = secondNumber;
            var ans = n1 - n2;
            Console.WriteLine("Sub of the result is {0}", ans);
        }
    }
}
