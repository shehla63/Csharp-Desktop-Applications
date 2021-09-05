using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagement
{
    class Student
    {
        private String firstName, lastName;
        private String studentNumber;

        public String getFirstName() {
            return firstName;
        }

        public String getLastName() {
            return lastName;
        }

        public String getStudentNumber(){
            return studentNumber;
        }

        public void setFirstName(String fName) {
            firstName = fName;
        }

        public void setLastName(String lName)
        {
            lastName = lName;
        }

        public void setStudenttNumber(String sNumber)
        {
            studentNumber = sNumber;
        }


    }
}
