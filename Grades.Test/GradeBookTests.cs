using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Grades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(55.65f);
            book.AddGrade(34.76f);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(55.65f, result.HighestGrade);

        }
      
        [TestMethod]
    public void ComputeLowestGrade()
    {
        GradeBook book = new GradeBook();
        book.AddGrade(55.65f);
        book.AddGrade(34.76f);

        GradeStatistics result = book.ComputeStatistics();

        Assert.AreEqual(34.76f, result.LowestGrade);

    }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(43);
            book.AddGrade(91.56f);
            book.AddGrade(77);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(70.5222222, result.AvgGrade, 0.01);

        }
    }
}

