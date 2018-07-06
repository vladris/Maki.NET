using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class MaybeTest
    {
        class T1 { }

        [TestMethod]
        public void MaybeTestAssignT1()
        {
            var item = new T1();
            Maybe<T1> maybe = item;

            Assert.IsTrue(maybe.HasValue);
            Assert.AreEqual(item, maybe.Get());
            Assert.AreEqual(item, (T1)maybe);
        }

        [TestMethod]
        public void MaybeTestJustT1()
        {
            var item = new T1();
            Maybe<T1> maybe = Maybe.Just(item);

            Assert.IsTrue(maybe.HasValue);
            Assert.AreEqual(item, maybe.Get());
            Assert.AreEqual(item, (T1)maybe);
        }

        [TestMethod]
        public void MaybeTestNothing()
        {
            Maybe<T1> maybe = Maybe.Nothing;

            Assert.IsFalse(maybe.HasValue);
            Assert.ThrowsException<InvalidCastException>(() => { maybe.Get(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)maybe; });
        }
    }
}
