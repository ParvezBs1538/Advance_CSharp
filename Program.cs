using System;

namespace Advance_CSharp
{
    // Generic Class
    public class Comparison<T>
    {
        public bool isEqual(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
    // Generic Method
    public class Comparison
    {
        public bool isEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use Generic Class
            Comparison<int> comp1 = new Comparison<int>();
            bool isEqual1 = comp1.isEqual(2, 2);

            Comparison<string> comp2 = new Comparison<string>();
            bool ieEqual2 = comp2.isEqual("Name", "name");

            Console.WriteLine(isEqual1 + " " + ieEqual2);


            // Use Generic Method
            Comparison comp3 = new Comparison();
            bool isEqual3 = comp3.isEqual<int>(2, 3);

            Comparison comp4 = new Comparison();
            bool isEqual4 = comp4.isEqual<string>("ID", "ID");

            Console.WriteLine(isEqual3 + " " + isEqual4);
        }
    }
}
