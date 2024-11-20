using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "A", 20));
            students.Add(new Student(2, "B", 22));
            students.Add(new Student(3, "c", 23));
            students.Add(new Student(4, "d", 18));
            students.Add(new Student(5, "e", 21));

            students.ForEach(student => Console.WriteLine(student));
            var ds = students.Where(student => student.Age >= 15 && student.Age <= 18).ToList();
            ds.ForEach(student => Console.WriteLine(student));
            Console.WriteLine();
            Student find1 = students.FirstOrDefault(s => s.Name == "A");
            Console.WriteLine(find1);
            Console.WriteLine();
            int tongTuoi = students.Sum(s => s.Age);
            Console.WriteLine(tongTuoi);
            Console.WriteLine();
            int find2 = students.Max(s => s.Age);
            Student st = students.FirstOrDefault(s => s.Age == find2);
            Console.WriteLine(st);
            Console.WriteLine();
            var ds2 = students.OrderBy(s => s.Age).ToList();
            ds2.ForEach(student => Console.WriteLine(student));
            Console.ReadLine();
        }
    }
}
