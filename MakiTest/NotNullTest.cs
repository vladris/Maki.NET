using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class NotNullTest
    {
        [TestMethod]
        public void NotNullItemTest()
        {
            var notNull = NotNull.Make("Foo");

            Assert.AreEqual("Foo", notNull.Item);
        }

        [TestMethod]
        public void NotNullNullTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new NotNull<string>(null));
        }

        [TestMethod]
        public void NotNullCastItemTest()
        {
            NotNull<string> notNull = "Foo";

            Action<string> action = (s) => Assert.AreEqual("Foo", s);

            action(notNull);
        }

        [TestMethod]
        public void NotNullCastNullTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => 
            {
                NotNull<object> notNull = null;
            });

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                NotNull<object> notNull = new object();
                notNull = null;
            });
        }

        [TestMethod]
        public void NotNullMakeOptionalNothing()
        {
            var optional = NotNull<string>.MakeOptional(null);
            Assert.IsFalse(optional.HasValue);
        }

        [TestMethod]
        public void NotNullMakeOptionalMake()
        {
            var optional = NotNull.MakeOptional("Foo");
            Assert.IsTrue(optional.HasValue);
            Assert.AreEqual("Foo", optional.Get().Item);
        }

        [TestMethod]
        public void NotNullEqualsTest()
        {
            Assert.IsFalse(NotNull.Make(new T1()).Equals(NotNull.Make(new T1())));
            Assert.IsTrue(NotNull.Make("test").Equals(NotNull.Make("test")));

            Assert.IsTrue("test".Equals(NotNull.Make("test")));

            Assert.IsFalse(NotNull.Make(new T1()).Equals(null));
        }

        [TestMethod]
        public void NotNullOperatorEqualsTest()
        {
            Assert.IsTrue(NotNull.Make("test") == NotNull.Make("test"));
        }
    }
}
