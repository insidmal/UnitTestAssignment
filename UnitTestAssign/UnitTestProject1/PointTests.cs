using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLib;

namespace UnitTestAssign.Tests
{
    [TestClass]
    class PointTests
    {
        
        [TestMethod]
        public void TestPointConstructor()
        {
            Point p = new Point();
            Assert.AreEqual(0,p.getX());
            Assert.AreEqual(0, p.getY());
        }

        [TestMethod]
        public void TestPoint()
        {
        }

        [TestMethod]
        public void TestGetX()
        {
        }

        [TestMethod]
        public void TestGetY()
        {
        }

        [TestMethod]
        public void TestStretch()
        {
            Point p = new Point(2, 3);
            Assert.AreEqual(6, p.getX());
            Assert.AreEqual(9, p.getY());

        }

        [TestMethod]
        public void TestDistance()
        {
        }

        [TestMethod]
        public void TestRotate()
        {
        }

        [TestMethod]
        public void TestToString()
        {
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
        }
        





    }
}
