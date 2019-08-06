using EntityFrameworkBegins.Models;
using System;
using System.Linq;

namespace EntityFrameworkBegins {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            //var students = context.students                
            //    .Where(s => s.GPA >= 3.0)
            //    .OrderByDescending(s => s.Lastname)
            //    .ToArray();

            //var students = context.students
            //    .OrderBy(s => s.Firstname)
            //    .ToArray();

            var studentAverageSat = context.students
                .Average(s => s.SAT);
            Console.WriteLine($"The average sat score is {studentAverageSat}");

            //foreach (var student in students) {
            //    Console.WriteLine($"{student.Firstname} {student.Lastname}");
            //}
        }
    }
}
