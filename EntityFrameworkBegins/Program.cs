using EntityFrameworkBegins.Models;
using System;
using System.Linq;

namespace EntityFrameworkBegins {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            var major = context.majors.Find(5);
            context.Remove(major);
   
            //Change Mathematics to Math
            //var major = context.majors.Find(2);
            //if (major == null) { // did not find it       
            //   throw new Exception("Not found!");
            //  }
            //major.Description = "Math";
            //major.MinSat = 1300;


            // easier to just add a collection of strings that represent the description
            //Added Biology
            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Biology";
            //major.MinSat = 1100;

            //context.majors.Add(major);

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSat = 1100;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Accounting";
            //major.MinSat = 1300;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Public Speaking";
            //major.MinSat = 5;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Golf Science";
            //major.MinSat = 1400;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "ESports";
            //major.MinSat = 800;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Sociology";
            //major.MinSat = 800;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "History";
            //major.MinSat = 900;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Political Science";
            //major.MinSat = 1000;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Theater";
            //major.MinSat = 200;
            //context.majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Computer Science";
            //major.MinSat = 1500;
            //context.majors.Add(major);
            //context.SaveChanges();

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

            //var students = context.students
            //          .Where(student => student.Major != null)
            //          .OrderBy(student => student.Major.Description)
            //          .ToList();


            //foreach (var student in students) {
            //    var major = (student.Major == null)
            //        ? "Undeclared"
            //        : student.Major.Description;
            //    Console.WriteLine(student);
            //}


        }
    }
}

   

