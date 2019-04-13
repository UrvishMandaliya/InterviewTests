using System;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker
{
    public class Repository
    {
        /// <summary>
        /// Get Student information
        /// </summary>
        /// <param name="id">Key Column</param>
        /// <returns>Student Model</returns>
        public static Student GetStudent(int id)
        {
            return GetStudents().FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Get Diploma information
        /// </summary>
        /// <param name="id">Key Column</param>
        /// <returns>Diploma Model</returns>
        public static Diploma GetDiploma(int id)
        {
            return GetDiplomas().FirstOrDefault(d => d.Id == id);
        }

        /// <summary>
        /// Get Requirement information
        /// </summary>
        /// <param name="id">Key Column</param>
        /// <returns>Requirement Model</returns>
        public static Requirement GetRequirement(int id)
        {
            return GetRequirements().FirstOrDefault(r => r.Id == id);
        }

        /// <summary>
        /// Get All Diplomas list
        /// </summary>
        /// <returns>Diploma List</returns>
        public static List<Diploma> GetDiplomas()
        {
            try
            {
                return new List<Diploma>
                {
                    new Diploma
                    {
                        Id = 1,
                        Credits = 4,
                        Requirements = new int[]{100,102,103,104}
                    }
                };
            }
            catch (Exception)
            {
                return new List<Diploma>();
            }
        }

        /// <summary>
        /// Get All Requirements List
        /// </summary>
        /// <returns>Requirements List</returns>
        public static List<Requirement> GetRequirements()
        {
            try
            {
                return new List<Requirement>
                {
                    new Requirement{Id = 100, Name = "Math", MinimumMark=50, Courses = new int[]{1}, Credits=1 },
                    new Requirement{Id = 102, Name = "Science", MinimumMark=50, Courses = new int[]{2}, Credits=1 },
                    new Requirement{Id = 103, Name = "Literature", MinimumMark=50, Courses = new int[]{3}, Credits=1},
                    new Requirement{Id = 104, Name = "Physichal Education", MinimumMark=50, Courses = new int[]{4}, Credits=1 }
                };
            }
            catch (Exception)
            {
                return new List<Requirement>();
            }
        }

        /// <summary>
        /// Get All Students List
        /// </summary>
        /// <returns>Students List</returns>
        public static List<Student> GetStudents()
        {
            try
            {
                return new List<Student>
                {
                   new Student
                   {
                       Id = 1,
                       Courses = new Course[]
                       {
                            new Course{Id = 1, Name = "Math", Mark=95 },
                            new Course{Id = 2, Name = "Science", Mark=95 },
                            new Course{Id = 3, Name = "Literature", Mark=95 },
                            new Course{Id = 4, Name = "Physichal Education", Mark=95 }
                       }
                   },
                   new Student
                   {
                       Id = 2,
                       Courses = new Course[]
                       {
                            new Course{Id = 1, Name = "Math", Mark=80 },
                            new Course{Id = 2, Name = "Science", Mark=80 },
                            new Course{Id = 3, Name = "Literature", Mark=80 },
                            new Course{Id = 4, Name = "Physichal Education", Mark=80 }
                       }
                   },
                    new Student
                    {
                        Id = 3,
                        Courses = new Course[]
                        {
                            new Course{Id = 1, Name = "Math", Mark=50 },
                            new Course{Id = 2, Name = "Science", Mark=50 },
                            new Course{Id = 3, Name = "Literature", Mark=50 },
                            new Course{Id = 4, Name = "Physichal Education", Mark=50 }
                        }
                    },
                    new Student
                    {
                        Id = 4,
                        Courses = new Course[]
                        {
                            new Course{Id = 1, Name = "Math", Mark=40 },
                            new Course{Id = 2, Name = "Science", Mark=40 },
                            new Course{Id = 3, Name = "Literature", Mark=40 },
                            new Course{Id = 4, Name = "Physichal Education", Mark=40 }
                        }
                    }
                };
            }
            catch (Exception)
            {
                return new List<Student>();
            }
        }
    }
}
