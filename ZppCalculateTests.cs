using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ZppCalculateTests
    {
        [TestMethod()]
        [DataRow(3540, 30, 12, 8850)]
        [DataRow(2978.62, 29, 7, 12340)]
        [DataRow(10322.58, 31, 20, 16000)]
        [DataRow(157.24, 29, 1, 4560)]
        [DataRow(15000, 28, 28, 15000)]
        [DataRow(25520, 30, 29, 26400)]
        [DataRow(1604.29, 28, 4, 11230)]
        public void GetZppTest(double res, double durationmonth, double otrabday, double salary)
        {
            var zpp = Math.Round(ZppCalculate.GetZpp(salary, durationmonth, otrabday),2);
            Assert.AreEqual(res, zpp);
        }

        [TestMethod()]
        [DataRow(3540, 32, 12, 8850)]
        [DataRow(2978.62, 29, 7, 0)]
        [DataRow(10322.58, 31, 0, 16000)]
        [DataRow(157.24, 2, 1, 4560)]
        [DataRow(15000, 20, 28, 15000)]
        [DataRow(25520, 30, 29, 0)]
        [DataRow(1604.29, 0, 4, 0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetZppInvalidArgsTest(double res, double durationmonth, double otrabday, double salary)
        {
            var zpp = Math.Round(ZppCalculate.GetZpp(salary, durationmonth, otrabday), 2);
            Assert.AreEqual(res, zpp);
        }
    }
}