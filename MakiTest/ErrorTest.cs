using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class ErrorTest
    {
        class T1 { }

        [TestMethod]
        public void ErrorTestException()
        {
            var e = new NotImplementedException();
            Error<T1> error = e;

            Assert.IsTrue(error.IsError);
            Assert.IsFalse(error.HasValue);
            Assert.AreEqual(e, (Exception)error);
            Assert.ThrowsException<InvalidCastException>(() => (T1)error);
        }

        [TestMethod]
        public void ErrorTestItem()
        {
            var item = new T1();
            Error<T1> error = item;

            Assert.IsFalse(error.IsError);
            Assert.IsTrue(error.HasValue);
            Assert.ThrowsException<InvalidCastException>(() => (Exception)error);
            Assert.AreEqual(item, (T1)error);
        }
    }
}
