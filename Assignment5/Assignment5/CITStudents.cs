using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class CITStudents : StudentInfo
    {
        private const int CITGradeHours = 70;
        private int hoursNeed = 0;

        public CITStudents()
        {
            hoursNeed = 0;
        }

        public CITStudents(string fName, string lName, string stuId, int credits, int hoursToGrad, int ARTGradeHours):base(fName, lName, stuId, credits)
        {
            hoursNeed = hoursToGrad;
        }

        public int HoursNeed
        {
            get { return hoursNeed; }
            set { hoursNeed = value; }
        }

        public int artGradeHours
        {
            get { return CITGradeHours; }
        }

        public override int hoursToGrad()
        {
            HoursNeed = CITGradeHours - CreditHours;

            return HoursNeed;
        }
    }
}
