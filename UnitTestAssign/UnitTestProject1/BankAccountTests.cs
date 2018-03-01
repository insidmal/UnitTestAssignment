using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace UnitTestAssign.Tests
{
    [TestClass]
    class BankAccountTests
    {
        [TestMethod]
        public void TestGetBalance()
        {
            BankAccount b = new BankAccount(200);
            Assert.AreEqual(200, b.getBalance());
        }
    }
}
