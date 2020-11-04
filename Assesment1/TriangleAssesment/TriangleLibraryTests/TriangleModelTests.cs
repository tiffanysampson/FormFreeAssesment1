using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleLibrary.Tests
{
    [TestClass()]
    public class TriangleModelTests
    {

        [TestMethod]
        public void Equilateral_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("30", "30", "30");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Equilateral.ToString(), testtype.ToString());
        }

        [TestMethod]
        public void Isosceles_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("30", "30", "40");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Isosceles.ToString(), testtype.ToString());
        }

        [TestMethod]
        public void Scalene_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("40", "10", "30");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Scalene.ToString(), testtype.ToString());
        }

        [TestMethod]
        public void NegativeError_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("-40", "10", "30");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Error.ToString(), testtype.ToString());
        }

        [TestMethod]
        public void ZEROError_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("0", "0", "0");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Error.ToString(), testtype.ToString());
        }

        [TestMethod]
        public void NonIntergerError_TriangleTest()
        {
            TriangleModel tm = new TriangleModel("Test", "0", "0");
            TriangleType testtype = tm.GetTriangleType(tm);

            Assert.AreEqual(TriangleType.Error.ToString(), testtype.ToString());
        }
    }
}