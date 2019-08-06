using EntityFrameworkBegins.Models;
using System;
using System.Linq;

namespace EntityFrameworkBegins {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            var students = context.students.ToArray();
            foreach (var student in students) {
                Console.WriteLine($"{student.Firstname} {student.Lastname}");
            }
        }
    }
}
