using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ArtStudents : StudentInfo
    {
        private const int ARTGradeHours = 70;
        private int hoursNeed = 0;

        public ArtStudents()
        {
            hoursNeed = 0;
        }

        public ArtStudents(string fName, string lName, string stuId, int credits, int hoursToGrad, int ARTGradeHours):base(fName, lName, stuId, credits)
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
            get { return ARTGradeHours; }
        }

        public override int hoursToGrad()
        {
            HoursNeed = ARTGradeHours - CreditHours;

            return HoursNeed;
        }

    }
}
