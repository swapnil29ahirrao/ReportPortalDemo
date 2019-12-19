using System;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestDataBug()
        {
            Assert.Fail("Test Data issue");
        }
        [Test]
        public void InvalidParameterException()
        {
            Assert.Fail("Invalid Parameter passed");
        }
        [Test]
        public void ElementNotFoundException()
        {
            Assert.Fail("Element not found");
        }
        [Test]
        public void newTestMethod()
        {
            Assert.Fail("Invalid Parameter passed");
        }
    }
}
