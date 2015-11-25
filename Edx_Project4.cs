using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Project4
{
    class Program
    {
        private static void Main(string[] args)
        {
            Student[] studentArray = new Student[5]; // <---- array of Student!
            studentArray[0].Fname = "Edx";
            studentArray[0].Lname = "Student";
            studentArray[0].Id = 123456789;
            studentArray[0].Numofcourses = 4;

            Console.WriteLine("Student First Name: {0}", studentArray[0].Fname);
            Console.WriteLine("Student Last Name: {0}", studentArray[0].Lname);
            Console.WriteLine("Student Id: {0}", studentArray[0].Id);
            Console.WriteLine("Student Number of Courses: {0}", studentArray[0].Numofcourses);

            Console.ReadLine();

        }
    }

    //Create student struct
    struct Student
    {
        private string fname;
        private string lname;
        private int id;
        private int numofcourses;

        public Student(string fname, string lname, int id, int numofcourses)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.numofcourses = numofcourses;
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Numofcourses
        {
            get { return numofcourses; }
            set { numofcourses = value; }
        }
    }

    //Create teacher struc
    struct Teacher
    {
        private string fname;
        private string lname;
        private int id;
        private int salary;

        public Teacher(string fname, string lname, int id, int salary)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.salary = salary;
        }


        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }

    //Create UniProgram Struct
    struct UniProgram
    {
        private string name;
        private string edulevel;

        public UniProgram(string name, string edulevel)
        {
            this.name = name;
            this.edulevel = edulevel;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Edulevel
        {
            get { return edulevel; }
            set { edulevel = value; }
        }
    }

    //Create Course struct
       struct Course
    {
        private string name;
        private int id;

        public Course(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
