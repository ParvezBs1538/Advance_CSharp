using System;

namespace Advance_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = new object[] { 2, 1, 3, 5, 4 };
            //object[] arr = new object[] {"par", "vez", "abc", "saif"};
            Employee[] arr = new Employee[]
            {
                new Employee {Id = 4, Name = "par"},
                new Employee {Id = 3, Name = "vez"},
                new Employee {Id = 5, Name = "saif"}
            };
            /*SortArray obj = new SortArray();
            obj.BubbleSort(arr);
            foreach (var it in arr)
                Console.Write(it + " ");*/
            SortArray<Employee> obj = new SortArray<Employee>();
            obj.BubbleSort(arr);
            foreach (var it in arr)
                Console.WriteLine((Employee)it + " ");
        }
    }
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Id.CompareTo(((Employee)obj).Id); // sort by Id
            //return this.Name.CompareTo(((Employee)obj).Name); // sort by Name
        }
        public override string ToString()
        {
            return $"{Id} -> {Name}";
        }
    }
    public class SortArray<T>
    {
        public void BubbleSort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(arr, j);
                    }
                }
            }
        }
        private void Swap(T[] arr, int i)
        {
            T tmp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = tmp;
        }
    }
}
