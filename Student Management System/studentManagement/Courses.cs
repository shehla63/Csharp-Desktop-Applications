using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagement
{
    class Courses
    {

        private String title;
        private String coded, courseNumber;

        public String getTitle()
        {
            return title;
        }

        public String getCoded()
        {
            return coded;
        }

        public String getCourseNumber()
        {
            return courseNumber;
        }

        public void setTitle(String t)
        {
            title = t;
        }

        public void setCoded(String c)
        {
            coded = c;
        }

        public void setCoursetNumber(String cNumber)
        {
            courseNumber = cNumber;
        }


    }
}
