using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.Model
{
    public static class AllStudents
    {
        public static IEnumerable<Student> Students { get; set;}

        public static IEnumerable<Student> GetAllStudents()
        {
            return Students = new List<Student>
            {
                new Student("Student 1 ",20),
                new Student("Student 2", 19),
                new Student("Student 3", 21)
            };
        }
    }
}
