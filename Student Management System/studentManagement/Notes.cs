using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagement
{
    class Notes
    {
        private String note;
        private String studentNumber, courseNumber;

        public String getNote()
        {
            return note;
        }

        public String getCourseNumber()
        {
            return courseNumber;
        }

        public String getStudentNumber()
        {
            return studentNumber;
        }

        public void setNote(String n)
        {
            note = n;
        }

        public void setCourseNumber(String cNumber)
        {
            courseNumber = cNumber;
        }

        public void setStudenttNumber(String sNumber)
        {
            studentNumber = sNumber;
        }

    }
}
