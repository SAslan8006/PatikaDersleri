using System;
using System.Linq;
using LinqPractices.DbOperations;
using LinqPractices.Entities;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find
            System.Console.WriteLine("**** Find ****");
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
            student = _context.Students.Find(2);
            System.Console.WriteLine(student.Name);

            //FirstOrDefault
            System.Console.WriteLine();
            System.Console.WriteLine("**** FirstOrDefault ****");
            student = _context.Students.Where(student => student.Surname == "Arda").FirstOrDefault();
            student = _context.Students.FirstOrDefault(x => x.Surname == "Arda");
            System.Console.WriteLine(student.Name);

            //SingleOrDefault
            System.Console.WriteLine();
            System.Console.WriteLine("**** SingleOrDefault ****");
            student = _context.Students.SingleOrDefault(x => x.Name == "Deniz");
            System.Console.WriteLine(student.Surname);

            //ToList
            System.Console.WriteLine();
            System.Console.WriteLine("**** ToList ****");
            var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();
            System.Console.WriteLine(studentList.Count);

            //OrderBy
            System.Console.WriteLine();
            System.Console.WriteLine("**** OrderBy ****");
            students = _context.Students.OrderBy(student => student.StudentId).ToList();
            foreach (var item in students)
            {
                System.Console.WriteLine(item.StudentId + " - " + item.Name + " - " + item.Surname + " - " + item.ClassId);
            }
            //OrderByDescending
            System.Console.WriteLine();
            System.Console.WriteLine("**** OrderByDescending ****");
            students = _context.Students.OrderByDescending(student => student.StudentId).ToList();
            foreach (var item in students)
            {
                System.Console.WriteLine(item.StudentId + " - " + item.Name + " - " + item.Surname + " - " + item.ClassId);
            }

            //Anonymous Object Result
            System.Console.WriteLine();
            System.Console.WriteLine("**** Anonymous Object Result ****");
            var anonymousObject = _context.Students.Where(x => x.ClassId == 2).Select(x => new
            {
                Id = x.StudentId,
                FullName = x.Name + " " + x.Surname
            }).ToList();

            foreach (var obj in anonymousObject)
            {
                System.Console.WriteLine(obj.Id + " - " + obj.FullName);
            }

        }
    }
}
