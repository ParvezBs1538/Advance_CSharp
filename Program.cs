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
            Student student1 = new Student()
            {
                Id = 35,
                Name = "Masud",
                Age = 25,
            };
            Student student2 = new Student()
            {
                Id = 38,
                Name = "Parvez",
                Age = 26,
            };

            List<Student> studentList = new List<Student>()
            {
                student1,
                student2,
                new Student() {Id = 15, Name = "Rifat", Age = 20},
            };
            Student student4 = new Student()
            {
                Id = 21,
                Name = "Saif",
                Age = 21,
            };
            studentList.Add(student4);

            foreach (var i in studentList)
            {
                Console.WriteLine($"{i.Id} {i.Name} {i.Age}");
            }
        }
    }
}
