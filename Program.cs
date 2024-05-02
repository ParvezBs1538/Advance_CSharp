namespace Advance_CSharp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 38,
                Name = "Parvez",
                Age = 25,
            }; 
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
        }
    }
}
