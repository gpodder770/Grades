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

            Assert.AreEqual(80, result.HighestGrade);

        }
    }
}
