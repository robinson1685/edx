using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx___Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //student info
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthdate = new DateTime(1999, 12, 31);
            string addressLine1 = "Foo Road 55";
            string addressLine2 = "c/o Fan Moe";
            string city = "Bar city";
            string state = "Uppland";
            string zipCode = "569 56";
            string country = "Sweden";

            //professor info
            string professorName = "Mike Tinker";
            string professorField = "Physics";

            //degree info
            string degreeLevel = "Master";
            double degreeLength = 4.5;

            //program info
            string programField = "Theoretical Physics";

            //course info
            string courseName = "Physics 101: The fundamentals";
            int coursePoints = 30;

            Console.WriteLine("New student information");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Born the {0}th of {1} in the year {2}", birthdate.Day, birthdate.ToString("MMM"), birthdate.Year);
            Console.WriteLine("Address: \n{0}", addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(state + " " + zipCode);
            Console.WriteLine(country);

            Console.WriteLine();

            Console.WriteLine("{0} is the professor of the department for {1}.", professorName, professorField);
            Console.WriteLine("You have started a {0}-year {1} degree at the {2} program.", degreeLength, degreeLevel, programField);
            Console.WriteLine("You have successfully registered for {0} : {1} points.", courseName, coursePoints);
            Console.WriteLine("We hope you enjoy your time here and study well {0}!", firstName);

            string line = Console.ReadLine();


        }
    }
}