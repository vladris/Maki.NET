using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest.Extensions
{
    [TestClass]
    public class ErrorExtensionsTest
    {
        [TestMethod]
        public void TestMapWithValue()
        {
            var error = Error.MakeValue(42);

            var result = error.Map(i => i * 2);

            Assert.IsTrue(result.HasValue);
            Assert.IsFalse(result.IsError);
            Assert.AreEqual(84, result.Get());
            Assert.ThrowsException<InvalidCastException>(() => result.Exception());
        }

        [TestMethod]
        public void TestMapWithError()
        {
            var ex = new Exception();
            var error = Error<int>.MakeException(ex);

            var result = error.Map(i => i * 2);

            Assert.IsFalse(result.HasValue);
            Assert.IsTrue(result.IsError);
            Assert.ThrowsException<InvalidCastException>(() => result.Get());
            Assert.AreEqual(ex, result.Exception());
        }

        [TestMethod]
        public void TestMapThrowing()
        {
            var ex = new Exception();
            var error = Error.MakeValue(42);

            var result = error.Map<int, int>(_ => throw ex);

            Assert.IsFalse(result.HasValue);
            Assert.IsTrue(result.IsError);
            Assert.ThrowsException<InvalidCastException>(() => result.Get());
            Assert.AreEqual(ex, result.Exception());
        }

        [TestMethod]
        public void TestBindWithValue()
        {
            var error = Error.MakeValue(42);

            var result = error.Bind(i => Error.MakeValue(i * 2));

            Assert.IsTrue(result.HasValue);
            Assert.IsFalse(result.IsError);
            Assert.AreEqual(84, result.Get());
            Assert.ThrowsException<InvalidCastException>(() => result.Exception());
        }

        [TestMethod]
        public void TestBindWithError()
        {
            var ex = new Exception();
            var error = Error<int>.MakeException(ex);

            var result = error.Bind(i => Error.MakeValue(i * 2));

            Assert.IsFalse(result.HasValue);
            Assert.IsTrue(result.IsError);
            Assert.ThrowsException<InvalidCastException>(() => result.Get());
            Assert.AreEqual(ex, result.Exception());
        }

        [TestMethod]
        public void TestBindThrowing()
        {
            var ex = new Exception();
            var error = Error.MakeValue(42);

            var result = error.Bind<int, int>(_ => throw ex);

            Assert.IsFalse(result.HasValue);
            Assert.IsTrue(result.IsError);
            Assert.ThrowsException<InvalidCastException>(() => result.Get());
            Assert.AreEqual(ex, result.Exception());
        }
    }
}
