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
        public void ErrorMakeValue()
        {
            var error = Error.MakeValue(42);

            Assert.IsTrue(error.HasValue);
            Assert.IsFalse(error.IsError);
            Assert.AreEqual(42, (int)error);
        }

        [TestMethod]
        public void ErrorMakeException()
        {
            var e = new NotImplementedException();
            var error = Error.MakeException<int>(e);

            Assert.IsFalse(error.HasValue);
            Assert.IsTrue(error.IsError);
            Assert.AreEqual(e, (Exception)error);
        }

        [TestMethod]
        public void ErrorMakeT()
        {
            var error = Error.Make(() => 42);

            Assert.IsTrue(error.HasValue);
            Assert.IsFalse(error.IsError);
            Assert.AreEqual(42, (int)error);
        }

        [TestMethod]
        public void ErrorMakeFromThrow()
        {
            var e = new NotImplementedException();
            var error = Error.Make<int>(() => throw e);

            Assert.IsFalse(error.HasValue);
            Assert.IsTrue(error.IsError);
            Assert.AreEqual(e, (NotImplementedException)error);
        }

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

        [TestMethod]
        public void ErrorTestEqualsItem()
        {
            var item = new T1();
            Error<T1> error1 = item;
            Error<T1> error2 = item;

            Assert.IsTrue(error1.Equals(error2));
            Assert.IsTrue(error2.Equals(error1));

            // item.Equals(error1) is false for non Error<T1> types so 
            // error1.Equals(item) should also return false in that case
            Assert.IsFalse(error1.Equals(item));
            Assert.IsFalse(item.Equals(error1));

            error2 = new T1();

            Assert.IsFalse(error1.Equals(error2));
            Assert.IsFalse(error2.Equals(error1));
        }

        [TestMethod]
        public void ErrorTestEqualsException()
        {
            var exception = new Exception();
            Error<T1> error1 = exception;
            Error<T1> error2 = exception;

            Assert.IsTrue(error1.Equals(error2));
            Assert.IsTrue(error2.Equals(error1));

            // exception.Equals(error1) is false for non Error<T1> types so 
            // error1.Equals(exception) should also return false in that case
            Assert.IsFalse(error1.Equals(exception));
            Assert.IsFalse(exception.Equals(error1));

            error2 = new T1();

            Assert.IsFalse(error1.Equals(error2));
            Assert.IsFalse(error2.Equals(error1));
        }
    }
}
