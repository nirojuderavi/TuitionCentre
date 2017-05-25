using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionCentre.BL
{
    public class StudentRepository
    {

        public Student Retrieve(int studentId)
        {
            Student student = new Student(studentId);

            if(studentId == 1)
            {
                
                student.FirstName = "Niro";
                student.LastName = "Ravi";
                student.StudentEmail = "niroravi@test.com";
            }

            return student;
        }


        public List<Student> Retrieve()
        {
            return new List<Student>();
        }

        public bool Save()
        {
            return true;
        }


    }
}
