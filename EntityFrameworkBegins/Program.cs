using EntityFrameworkBegins.Models;
using System;
using System.Linq;

namespace EntityFrameworkBegins {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();
            //foreach (var major in context.majors.ToList()) {
            //    Console.WriteLine(major);
            //}

            //var genStudies = context.majors.Find(1);
            //Console.WriteLine(genStudies);

            //var students = context.students                
            //    .Where(s => s.GPA >= 3.0)
            //    .OrderByDescending(s => s.Lastname)
            //    .ToArray();

            //var students = context.students
            //    .OrderBy(s => s.Firstname)
            //    .ToArray();

            //var students = context.students
            //    .OrderBy(s => s.Lastname)
            //    .ToArray();

            //var studentAverageSat = context.students
            //    .Average(s => s.SAT);
            //Console.WriteLine($"The average sat score is {studentAverageSat}");

            //foreach (var student in students) {
            //    var major = (student.Major == null) 
            //        ? "Undeclared" 
            //        : student.Major.Description;
            //    Console.WriteLine($"{student.Firstname} {student.Lastname} {major}");

            //var students = context.students.ToArray();

            var students = context.students
                      .Where(student => student.Major != null)
                      .OrderBy(student => student.Major.Description)
                      .ToList();


            foreach (var student in students) {
                var major = (student.Major == null)
                    ? "Undeclared"
                    : student.Major.Description;
                Console.WriteLine(student);
            }

        }
    }
}

   

