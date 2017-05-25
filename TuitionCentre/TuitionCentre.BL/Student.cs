using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionCentre.BL
{
    public class Student
    {
        //comment to push to github

        public Student()
        {
                
        }

        public Student(int studnetId)
        {
            this.StudentId = studnetId;
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentEmail { get; set; }

        public int StudentId { get; private set; }

        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StudentEmail))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
