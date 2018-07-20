using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MakiTest
{
    [TestClass]
    public class OptionalExtensionsTest
    {
        [TestMethod]
        public void TestMapWithSomething()
        {
            var optional = Optional.Just(42);

            var result = optional.Map(i => i * 2);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(84, result.Get());
        }

        [TestMethod]
        public void TestMapWithNothing()
        {
            var optional = Optional<int>.Nothing;

            var result = optional.Map(i => i * 2);

            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void TestBindWithSomething()
        {
            var optional = Optional.Just(42);

            var result = optional.Bind(i => Optional.Just(i * 2));

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(84, result.Get());
        }

        [TestMethod]
        public void TestBindWithNothing()
        {
            var optional = Optional<int>.Nothing;

            var result = optional.Bind(i => Optional.Just(i * 2));

            Assert.IsFalse(result.HasValue);
        }
    }
}
