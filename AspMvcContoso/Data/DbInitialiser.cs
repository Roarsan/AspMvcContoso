﻿using AspMvcContoso.Models;

namespace AspMvcContoso.Data
{
    public class DbInitialiser
    { 
        public static void Initialize(ApplicationDbContext context)
            {
                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                new Student{FirstMidName="Jyoti",LastName="Tamang",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="Narinder",LastName="Karki",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Sudath",LastName="Regmi",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Jessica",LastName="Magar",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Yam",LastName="Khadka",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Deepesh",LastName="Bhattarai",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstMidName="Peter",LastName="Parker",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Dwayne",LastName="Johnson",EnrollmentDate=DateTime.Parse("2019-09-01")}
                };

                context.Students.AddRange(students);
                context.SaveChanges();

                var courses = new Course[]
                {
                new Course{CourseID=1050,Title="Web app",Credits=3},
                new Course{CourseID=4022,Title="Database",Credits=3},
                new Course{CourseID=4041,Title="Modelling",Credits=3},
                new Course{CourseID=1045,Title="Programming",Credits=4},
                new Course{CourseID=3141,Title="Apps Development",Credits=4},
                new Course{CourseID=2021,Title="Networking",Credits=3},
                new Course{CourseID=2042,Title="Digital Technology",Credits=4}
                };

                context.Courses.AddRange(courses);
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
                };

                context.Enrollments.AddRange(enrollments);
                context.SaveChanges();
            }
        }
    }


