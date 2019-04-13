using System;

namespace GraduationTracker
{
    public class GraduationTracker
    {

        public Tuple<bool, Standing> HasGraduated(Diploma diploma, Student student)
        {
            int average = 0;
            CalculateAverage(diploma, student, ref average);
            return CheckGraduation(average);
        }

        /// <summary>
        /// Process Student average and check Graduation
        /// </summary>
        /// <param name="average"> Average Course Mark</param>
        /// <returns>IsGraduated and Standings</returns>
        private Tuple<bool, Standing> CheckGraduation(int average)
        {
            Standing standing = Standing.None;

            if (average < 50)
            {
                standing = Standing.Remedial;
            }
            else if (average < 70)
            {
                standing = Standing.Average;
            }
            else if (average < 90)
            {
                standing = Standing.MagnaCumLaude;
            }
            else
            {
                standing = Standing.SumaCumLaude;
            }

            switch (standing)
            {
                case Standing.Remedial:
                    return new Tuple<bool, Standing>(false, standing);
                case Standing.Average:
                    return new Tuple<bool, Standing>(true, standing);
                case Standing.SumaCumLaude:
                    return new Tuple<bool, Standing>(true, standing);
                case Standing.MagnaCumLaude:
                    return new Tuple<bool, Standing>(true, standing);
                default:
                    return new Tuple<bool, Standing>(false, standing);
            }
        }

        /// <summary>
        /// Calculate average from Student Courses and Diploma Requirements
        /// </summary>
        /// <param name="diploma"></param>
        /// <param name="student"></param>
        /// <param name="average"></param>
        private static void CalculateAverage(Diploma diploma, Student student, ref int average)
        {
            foreach (int req in diploma.Requirements)
            {
                foreach (Course course in student.Courses)
                {
                    Requirement requirement = Repository.GetRequirement(req);

                    foreach (int c in requirement.Courses)
                    {
                        if (c == course.Id)
                        {
                            average += course.Mark;
                        }
                    }
                }
            }
            average = average / student.Courses.Length;
        }
    }
}
