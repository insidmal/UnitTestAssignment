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
        public void TestDeposit()
        {
            BankAccount b = new BankAccount(20);
            Assert.IsTrue(b.deposit(10));
        }
    }
}
