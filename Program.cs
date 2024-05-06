using System;
namespace Advance_CSharp
{
    internal class Program
    {
        public delegate void Calculator(int num1, int num2);
        static void Main(string[] args)
        {
            //Calculator calculate = Add;
            Calculator calculate = new Calculator(Add);
            //Calculator calculate = (x, y) => Add(x, y);

        // calculate sum
            calculate.Invoke(40, 12);
            //calculate(40, 12);

        // calculate sub
            calculate = Sub;
            calculate(40, 12);
        }
        public static void Add(int firstNumber, int secondNumber)
        {
            int ans = firstNumber + secondNumber;
            Console.WriteLine("Sum of the result is {0}", ans);
        }
        public static void Sub(int firstNumber, int secondNumber)
        {
            int ans = firstNumber - secondNumber;
            Console.WriteLine("Sub of the result is {0}", ans);
        }
    }
}
