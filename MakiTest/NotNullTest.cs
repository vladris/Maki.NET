﻿using Maki;
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
            var notNull = new NotNull<string>("Foo");

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
        public void NotNullMakeMaybeNothing()
        {
            var maybe = NotNull<string>.MakeMaybe(null);
            Assert.IsFalse(maybe.HasValue);
        }

        [TestMethod]
        public void NotNullMakeMaybeJust()
        {
            var maybe = NotNull<string>.MakeMaybe("Foo");
            Assert.IsTrue(maybe.HasValue);
            Assert.AreEqual("Foo", maybe.Get().Item);
        }
    }
}
