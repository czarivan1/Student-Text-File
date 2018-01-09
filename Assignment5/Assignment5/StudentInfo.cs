using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class StudentInfo
    {
        private string firstName;
        private string lastName;
        private string studentId;
        private int creditHours;

        public StudentInfo()
        {
            firstName = "";
            lastName = "";
            studentId = "";
            creditHours = 0;
        }

        public StudentInfo(string fName, string lName, string stuId, int credits)
        {
            firstName = fName;
            lastName = lName;
            studentId = stuId;
            creditHours = credits;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        public abstract int hoursToGrad();
    }
}
