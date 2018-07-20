using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class OptionalTest
    {
        class T1 { }

        [TestMethod]
        public void OptionalTestAssignT1()
        {
            var item = new T1();
            Optional<T1> optional = item;

            Assert.IsTrue(optional.HasValue);
            Assert.AreEqual(item, optional.Get());
            Assert.AreEqual(item, (T1)optional);
        }

        [TestMethod]
        public void OptionalTestMakeT1()
        {
            var item = new T1();
            Optional<T1> optional = Optional.Make(item);

            Assert.IsTrue(optional.HasValue);
            Assert.AreEqual(item, optional.Get());
            Assert.AreEqual(item, (T1)optional);
        }

        [TestMethod]
        public void OptionalTestNothing()
        {
            Optional<T1> optional = Optional.Nothing;

            Assert.IsFalse(optional.HasValue);
            Assert.ThrowsException<InvalidCastException>(() => { optional.Get(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)optional; });
        }

        [TestMethod]
        public void OptionalEqualsTest()
        {
            Assert.IsFalse(Optional.Make(new T1()).Equals(Optional.Make(new T1())));
            Assert.IsTrue(Optional.Make("test").Equals(Optional.Make("test")));

            Assert.IsFalse(Optional.Make(new T1()).Equals(Optional<T1>.Nothing));
            Assert.IsFalse(Optional<T1>.Nothing.Equals(Optional.Make(new T1())));
            Assert.IsTrue(Optional<T1>.Nothing.Equals(Optional<T1>.Nothing));

            Assert.IsFalse("test".Equals(Optional.Make("test")));
            Assert.IsFalse(Optional.Make("test").Equals("test"));
            Assert.IsTrue("test".Equals((string)Optional.Make("test")));

            Assert.IsFalse(Optional.Make("test").Equals(null));
        }
    }
}
