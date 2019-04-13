using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        private Diploma _diploma;
        private List<Student> _lstStudents;
        private GraduationTracker _graduationTracker;

        public GraduationTrackerTests()
        {
            GetData();
            _graduationTracker = new GraduationTracker();
        }

        private void GetData()
        {
            _diploma = Repository.GetDiploma(1);

            _lstStudents = Repository.GetStudents();
        }

        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();
            
            var graduated = new List<Tuple<bool, Standing>>();

            foreach(var student in _lstStudents)
            {
                graduated.Add(tracker.HasGraduated(_diploma, student));      
            }
                        
            Assert.IsTrue(graduated.Any());

        }

        [TestMethod]
        public void HasAnyStudentGraduatedWithAvrage()
        {
            var result = _graduationTracker.HasGraduated(_diploma, _lstStudents.FirstOrDefault(a => a.Id == 3));
            Assert.AreEqual(result.Item1 , true);
            Assert.AreEqual(result.Item2, Standing.Average);
        }

        [TestMethod]
        public void HasAnyStudentGraduatedWithSumaCumLaude()
        {
            var result = _graduationTracker.HasGraduated(_diploma, _lstStudents.FirstOrDefault(a => a.Id == 1));
            Assert.AreEqual(result.Item1, true);
            Assert.AreEqual(result.Item2, Standing.SumaCumLaude);
        }

        [TestMethod]
        public void HasAnyStudentGraduatedWithMagnaCumLaude()
        {
            var result = _graduationTracker.HasGraduated(_diploma, _lstStudents.FirstOrDefault(a => a.Id == 2));
            Assert.AreEqual(result.Item1, true);
            Assert.AreEqual(result.Item2, Standing.MagnaCumLaude);
        }

        [TestMethod]
        public void HasAnyStudentRemidial()
        {
            var result = _graduationTracker.HasGraduated(_diploma, _lstStudents.FirstOrDefault(a => a.Id == 4));
            Assert.AreEqual(result.Item1, true);
            Assert.AreEqual(result.Item2, Standing.Remedial);
        }
    }
}
