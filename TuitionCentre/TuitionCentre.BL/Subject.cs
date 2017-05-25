using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionCentre.BL
{
    public class Subject
    {
        public Subject()
        {
            
        }

        public Subject(int subjectId)
        {
            this.SubjectId = subjectId;
        }

        public int SubjectId { get; private set; }

        public string SubjectName { get; set; }

        public string SubjectDesrciption { get; set;}

        public Decimal? CurrentSubjectPrice { get; set; }


        public Student Retrieve()
        {
            return new Student();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(SubjectName))
            {
                isValid = false;
            }

            if(CurrentSubjectPrice == null)
            {
                isValid = false;
            }

            return isValid;

        }
    }
}
