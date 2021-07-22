namespace NagpurUniversity.Migrations
{
    using NagpurUniversity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NagpurUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NagpurUniversity.DAL.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
              
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

            students.ForEach(s => context.Students.AddOrUpdate(p => p.FName, s));
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
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {

                new Enrollment {
                    StudentID = students.Single(s => s.FName == "Sandy").ID,
                    CourseID = courses.Single(c => c.Title == "Ruby" ).CourseID,
                    Grade = Grade.A
                },

                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Sandy").ID,
                    CourseID = courses.Single(c => c.Title == "Java" ).CourseID,
                    Grade = Grade.C
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Sandy").ID,
                    CourseID = courses.Single(c => c.Title == "C" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                     StudentID = students.Single(s => s.FName == "Payal").ID,
                    CourseID = courses.Single(c => c.Title == "Python" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                     StudentID = students.Single(s => s.FName == "Payal").ID,
                    CourseID = courses.Single(c => c.Title == "C++" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Mayur").ID,
                    CourseID = courses.Single(c => c.Title == "Php" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Pulkit").ID,
                    CourseID = courses.Single(c => c.Title == "C#" ).CourseID
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Yomesh").ID,
                    CourseID = courses.Single(c => c.Title == "Java").CourseID,
                    Grade = Grade.B
                 },
                new Enrollment {
                    StudentID = students.Single(s => s.FName == "Nikhil").ID,
                    CourseID = courses.Single(c => c.Title == "C").CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Garry").ID,
                    CourseID = courses.Single(c => c.Title == "C").CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.FName == "Garry").ID,
                    CourseID = courses.Single(c => c.Title == "Python").CourseID,
                    Grade = Grade.B
                 }
            };
            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                         s.Student.ID == e.StudentID &&
                         s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}
