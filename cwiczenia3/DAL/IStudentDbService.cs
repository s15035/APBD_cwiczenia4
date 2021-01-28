using cwiczenia3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenia3.DAL
{
    public interface IStudentDbService
    {
        public IEnumerable<Student> GetStudents();
        public Student GetStudent(string index);
        public int CreateStudent(Student newStudent);
        public int DeleteStudent(string index);
        public int UpdateStudent(Student reStudent);
        public Enrollment Enrollments(string index);
    }
}
