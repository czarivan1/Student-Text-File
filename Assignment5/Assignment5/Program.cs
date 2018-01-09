using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtStudents[] artists;
            CITStudents[] computers;

            readData(out artists, out computers);
            display(artists, computers);
        }

        public static void readData(out ArtStudents[] artists, out CITStudents[] computers)
        {
            int numCIT;
            int numART;

            StreamReader citFile = new StreamReader("CITstudent.txt");

            numCIT = Convert.ToInt32(citFile.ReadLine());

            computers = new CITStudents[numCIT];

            for (int i = 0; i < numCIT; i++)
            {
                computers[i] = new CITStudents();
            }

            for (int i = 0; i < numCIT; i++)
            {
                computers[i].FirstName = citFile.ReadLine();
                computers[i].LastName = citFile.ReadLine();
                computers[i].StudentId = citFile.ReadLine();
                computers[i].CreditHours = Convert.ToInt32(citFile.ReadLine());
                computers[i].hoursToGrad();
            }

            citFile.Close();

            StreamReader artFile = new StreamReader("ARTstudent.txt");

            numART = Convert.ToInt32(artFile.ReadLine());

            artists = new ArtStudents[numART];

            for (int i = 0; i < numART; i++)
            {
                artists[i] = new ArtStudents();
            }

            for (int i = 0; i < numCIT; i++)
            {
                artists[i].FirstName = artFile.ReadLine();
                artists[i].LastName = artFile.ReadLine();
                artists[i].StudentId = artFile.ReadLine();
                artists[i].CreditHours = Convert.ToInt32(artFile.ReadLine());
                artists[i].hoursToGrad();
            }

            
            artFile.Close();

        }

        public static void display(ArtStudents[] artists, CITStudents[] computers)
        {
            Console.WriteLine("Computer Science Students: ");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < computers.Length; i++)
            {
                Console.WriteLine("{0} {1} needs {2} to graduate", 
                                  computers[i].FirstName, computers[i].LastName, computers[i].HoursNeed);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Art Students: ");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < artists.Length; i++)
            {
                Console.WriteLine("{0} {1} needs {2} to graduate", 
                                  artists[i].FirstName, artists[i].LastName, artists[i].HoursNeed);
            }

        }
    }
}
