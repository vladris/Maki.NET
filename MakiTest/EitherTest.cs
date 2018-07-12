using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class Eitherest
    {
        class T1 { }
        class T2 { }

        [TestMethod]
        public void EitherTestLeft()
        {
            var item = new T1();
            Either<T1, T2> either = item;

            Assert.IsTrue(either.IsLeft);
            Assert.IsFalse(either.IsRight);
            Assert.AreEqual(item, either.GetLeft());
            Assert.ThrowsException<InvalidCastException>(() => either.GetRight());
        }

        [TestMethod]
        public void EitherTestRight()
        {
            var item = new T2();
            Either<T1, T2> either = item;

            Assert.IsFalse(either.IsLeft);
            Assert.IsTrue(either.IsRight);
            Assert.ThrowsException<InvalidCastException>(() => either.GetLeft());
            Assert.AreEqual(item, either.GetRight());
        }

        [TestMethod]
        public void EitherTestLeftSameType()
        {
            var item = new T1();
            var either = Either<T1, T1>.MakeLeft(item);

            Assert.IsTrue(either.IsLeft);
            Assert.IsFalse(either.IsRight);
            Assert.AreEqual(item, either.GetLeft());
            Assert.ThrowsException<InvalidCastException>(() => either.GetRight());
        }

        [TestMethod]
        public void EitherTestRightSameType()
        {
            var item = new T2();
            var either = Either<T2, T2>.MakeRight(item);

            Assert.IsFalse(either.IsLeft);
            Assert.IsTrue(either.IsRight);
            Assert.ThrowsException<InvalidCastException>(() => either.GetLeft());
            Assert.AreEqual(item, either.GetRight());
        }

        [TestMethod]
        public void EitherTestAssignLeft()
        {
            var item = new T1();
            Either<T1, T2> either = new T2();
            either.Set(item);

            Assert.IsTrue(either.IsLeft);
            Assert.IsFalse(either.IsRight);
            Assert.AreEqual(item, either.GetLeft());
            Assert.ThrowsException<InvalidCastException>(() => either.GetRight());
        }

        [TestMethod]
        public void EitherTestAssignRight()
        {
            var item = new T2();
            Either<T1, T2> either = new T1();
            either.Set(item);

            Assert.IsFalse(either.IsLeft);
            Assert.IsTrue(either.IsRight);
            Assert.ThrowsException<InvalidCastException>(() => either.GetLeft());
            Assert.AreEqual(item, either.GetRight());
        }
    }
}
