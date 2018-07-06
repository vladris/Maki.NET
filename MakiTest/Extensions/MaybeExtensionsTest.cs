using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MakiTest
{
    [TestClass]
    public class MaybeExtensionsTest
    {
        [TestMethod]
        public void TestMapWithSomething()
        {
            var maybe = Maybe.Just(42);

            var result = maybe.Map(i => i * 2);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(84, result.Get());
        }

        [TestMethod]
        public void TestMapWithNothing()
        {
            var maybe = Maybe<int>.Nothing;

            var result = maybe.Map(i => i * 2);

            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void TestBindWithSomething()
        {
            var maybe = Maybe.Just(42);

            var result = maybe.Bind(i => Maybe.Just(i * 2));

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(84, result.Get());
        }

        [TestMethod]
        public void TestBindWithNothing()
        {
            var maybe = Maybe<int>.Nothing;

            var result = maybe.Bind(i => Maybe.Just(i * 2));

            Assert.IsFalse(result.HasValue);
        }
    }
}
