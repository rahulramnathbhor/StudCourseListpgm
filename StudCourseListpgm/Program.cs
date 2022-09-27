using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudCourseListpgm
{
    public class Student
    {
        public string sname { get; set; }
        public string city { get; set; }

    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public Student[] Students { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1 = new Student[]
            {
              new Student{sname="Rahul",city="Pune" },
             new Student{ sname = "Sham",city = "satara"}
            };

            Student[] stud2 = new Student[]
            {
              new Student{sname="Radha",city="Sangli" },
               new Student{sname="Gopal",city="Bihar" },
               new Student{sname="Kunal",city="Uttrakhand" }
            };
            Student[] stud3 = new Student[]
            {
                 new Student{sname="Ramesh",city="Madhyapradesh" },
                  new Student{sname="Sumit",city="Zarkhand" },
                   new Student{sname="Kumar",city="Bhopal" },
            };
                Course[] courses = new Course[]
                {
                  new Course{Id=1,Name="C#",Fees=25000,Students=stud1},
                  new Course{Id=2,Name="Java",Fees=27000,Students=stud2},
                  new Course{Id=3,Name="MVC",Fees=40000,Students=stud3},

                };
            foreach(Course c in courses)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                foreach (Student s in c.Students)
                {
                    Console.WriteLine($"\t {s.sname} -> {s.city}");
                }
            }

        }
    }
}

    


   

