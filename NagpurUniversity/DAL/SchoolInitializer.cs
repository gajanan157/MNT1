using NagpurUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NagpurUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FName="Sandy",  MName="Prakash", LName="Shinde",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FName="Mayur",MName="Vinod", LName="Asekar",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FName="Tushar",  MName="Ajay", LName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FName="Garry",   MName="Mahesh", LName="Barde",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FName="Yomesh",     MName="Mangesh", LName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FName="Payal",   MName="Gautam", LName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FName="Pulkit",   MName="Vilas", LName="Sidhart",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FName="Nikhil",    MName="Vikas", LName="Zade",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Java",Credits=3,},
            new Course{CourseID=4022,Title="C++",Credits=3,},
            new Course{CourseID=4041,Title="Python",Credits=3,},
            new Course{CourseID=1045,Title="C#",Credits=4,},
            new Course{CourseID=3141,Title="C",Credits=4,},
            new Course{CourseID=2021,Title="Php",Credits=3,},
            new Course{CourseID=2042,Title="Ruby",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.E},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.E},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.E},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
