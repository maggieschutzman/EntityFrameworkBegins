using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkBegins;


namespace TestEducationProject {

    [TestClass]
    public class UnitTest1 {

        //AppDbContext context = null;

        [TestInitialize]
        public void TestInit() {          
        }

        [TestMethod]
        public void TestStudentGetbyLastname() {
            var student = Program.GetStudentByLastname("Zumwalde");
            Assert.IsNotNull(student);
            Assert.AreEqual("Zumwalde", student.Lastname);
            student = Program.GetStudentByLastname("Dooe");
            Assert.IsNull(student, "student is null"); // if we don't find it, it should be null & test passes
        }

        [TestMethod]
        public void TestStudentGetByPK() {
            var zumwalde = Program.GetStudentById(1);
            Assert.IsNotNull(zumwalde);
            Assert.AreEqual("Zumwalde", zumwalde.Lastname);
            var nobody = Program.GetStudentById(12242);
            Assert.IsNull(nobody);

        }
    }
}


