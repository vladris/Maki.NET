using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    class T1 { }

    class T2 { }

    [TestClass]
    public class Variant2Test
    {
        [TestMethod]
        public void Variant2TestMake1()
        {
            var variant = Variant<int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant2TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
        }

        [TestMethod]
        public void Variant2TestMake2()
        {
            var variant = Variant<int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant2TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
        }

    }
    class T3 { }

    [TestClass]
    public class Variant3Test
    {
        [TestMethod]
        public void Variant3TestMake1()
        {
            var variant = Variant<int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant3TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
        }

        [TestMethod]
        public void Variant3TestMake2()
        {
            var variant = Variant<int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant3TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
        }

        [TestMethod]
        public void Variant3TestMake3()
        {
            var variant = Variant<int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant3TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
        }

    }
    class T4 { }

    [TestClass]
    public class Variant4Test
    {
        [TestMethod]
        public void Variant4TestMake1()
        {
            var variant = Variant<int, int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
        }

        [TestMethod]
        public void Variant4TestMake2()
        {
            var variant = Variant<int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
        }

        [TestMethod]
        public void Variant4TestMake3()
        {
            var variant = Variant<int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
        }

        [TestMethod]
        public void Variant4TestMake4()
        {
            var variant = Variant<int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestAssignT4()
        {
            var item = new T4();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.AreEqual(3, variant.Index);
            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());
            Assert.AreEqual(item, (T4)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
        }

    }
    class T5 { }

    [TestClass]
    public class Variant5Test
    {
        [TestMethod]
        public void Variant5TestMake1()
        {
            var variant = Variant<int, int, int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
        }

        [TestMethod]
        public void Variant5TestMake2()
        {
            var variant = Variant<int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
        }

        [TestMethod]
        public void Variant5TestMake3()
        {
            var variant = Variant<int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
        }

        [TestMethod]
        public void Variant5TestMake4()
        {
            var variant = Variant<int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestAssignT4()
        {
            var item = new T4();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.AreEqual(3, variant.Index);
            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());
            Assert.AreEqual(item, (T4)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
        }

        [TestMethod]
        public void Variant5TestMake5()
        {
            var variant = Variant<int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestAssignT5()
        {
            var item = new T5();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.AreEqual(4, variant.Index);
            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());
            Assert.AreEqual(item, (T5)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
        }

    }
    class T6 { }

    [TestClass]
    public class Variant6Test
    {
        [TestMethod]
        public void Variant6TestMake1()
        {
            var variant = Variant<int, int, int, int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

        [TestMethod]
        public void Variant6TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

        [TestMethod]
        public void Variant6TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

        [TestMethod]
        public void Variant6TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT4()
        {
            var item = new T4();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(3, variant.Index);
            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());
            Assert.AreEqual(item, (T4)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

        [TestMethod]
        public void Variant6TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT5()
        {
            var item = new T5();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(4, variant.Index);
            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());
            Assert.AreEqual(item, (T5)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

        [TestMethod]
        public void Variant6TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestAssignT6()
        {
            var item = new T6();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.AreEqual(5, variant.Index);
            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());
            Assert.AreEqual(item, (T6)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
        }

    }
    class T7 { }

    [TestClass]
    public class Variant7Test
    {
        [TestMethod]
        public void Variant7TestMake1()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT4()
        {
            var item = new T4();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(3, variant.Index);
            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());
            Assert.AreEqual(item, (T4)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT5()
        {
            var item = new T5();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(4, variant.Index);
            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());
            Assert.AreEqual(item, (T5)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT6()
        {
            var item = new T6();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(5, variant.Index);
            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());
            Assert.AreEqual(item, (T6)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

        [TestMethod]
        public void Variant7TestMake7()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make7(42);

            Assert.AreEqual(6, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestAssignT7()
        {
            var item = new T7();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.AreEqual(6, variant.Index);
            Assert.IsTrue(variant.Is<T7>());
            Assert.AreEqual(item, variant.Get<T7>());
            Assert.AreEqual(item, (T7)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
        }

    }
    class T8 { }

    [TestClass]
    public class Variant8Test
    {
        [TestMethod]
        public void Variant8TestMake1()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT1()
        {
            var item = new T1();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT2()
        {
            var item = new T2();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(1, variant.Index);
            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());
            Assert.AreEqual(item, (T2)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT3()
        {
            var item = new T3();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(2, variant.Index);
            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());
            Assert.AreEqual(item, (T3)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT4()
        {
            var item = new T4();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(3, variant.Index);
            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());
            Assert.AreEqual(item, (T4)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT5()
        {
            var item = new T5();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(4, variant.Index);
            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());
            Assert.AreEqual(item, (T5)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT6()
        {
            var item = new T6();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(5, variant.Index);
            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());
            Assert.AreEqual(item, (T6)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake7()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make7(42);

            Assert.AreEqual(6, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT7()
        {
            var item = new T7();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(6, variant.Index);
            Assert.IsTrue(variant.Is<T7>());
            Assert.AreEqual(item, variant.Get<T7>());
            Assert.AreEqual(item, (T7)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T8>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T8>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T8)variant; });
        }

        [TestMethod]
        public void Variant8TestMake8()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make8(42);

            Assert.AreEqual(7, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestAssignT8()
        {
            var item = new T8();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.AreEqual(7, variant.Index);
            Assert.IsTrue(variant.Is<T8>());
            Assert.AreEqual(item, variant.Get<T8>());
            Assert.AreEqual(item, (T8)variant);

            Assert.IsFalse(variant.Is<T1>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T1>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T1)variant; });
            Assert.IsFalse(variant.Is<T2>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T2>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T2)variant; });
            Assert.IsFalse(variant.Is<T3>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T3)variant; });
            Assert.IsFalse(variant.Is<T4>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T4>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T4)variant; });
            Assert.IsFalse(variant.Is<T5>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T5>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T5)variant; });
            Assert.IsFalse(variant.Is<T6>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T6>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T6)variant; });
            Assert.IsFalse(variant.Is<T7>());
            Assert.ThrowsException<InvalidCastException>(() => { variant.Get<T7>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var _ = (T7)variant; });
        }

    }
}
