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
            Point p = new Point(2,2);
            Assert.AreEqual(p.getX(), 2);
            Assert.AreEqual(p.getY(), 2);
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

            Point p = new Point(1,2);
            Point other = new Point(2, 3);
            double distance = p.distance(other);
            Assert.AreEqual(distance, 17);
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
            Point p1 = new Point(2,2);
            Point p2 = new Point(1,1);
            Assert.IsTrue(p1 > p2);
            Assert.IsFalse(p2 > p1);
        }
        





    }
}
