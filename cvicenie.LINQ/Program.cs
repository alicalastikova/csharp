using System.Linq;

namespace cvicenie.LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Anna Maria", Age = 20 },
                new Student { Name = "Anna Hruskova", Age = 40 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 18 },


            };
            /*List<Student> tinedzeriStudenti_StariSposob = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Age < 20)
                {
                    tinedzeriStudenti_StariSposob.Add(student);
                }

            }*/
            List<Student> tinedzeriStudenti = students.Where(student => true).ToList();
            /*foreach (Student student in tinedzeriStudenti)
            {
                Console.WriteLine($"StarySposob:Student, {student.Name} ma {student.Age} a je tinedyer.");
            }*/
            foreach (Student student in tinedzeriStudenti)
            {
                Console.WriteLine($"LINQ: Student,{student.Name} ma {student.Age} a je tinedyer");
            }
        }
    }
}
