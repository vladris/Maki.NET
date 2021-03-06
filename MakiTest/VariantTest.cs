﻿using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    class T1 { }

    class DerivedFromT1 : T1 { }

    [TestClass]
    public class Variant1Test
    {
        [TestMethod]
        public void Variant1TestMake1()
        {
            var variant = Variant<int>.Make1(42);

            Assert.AreEqual(0, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant1TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
        }

        [TestMethod]
        public void Variant1TestAssignT1()
        {
            var item = new T1();
            Variant<T1> variant = item;

            Assert.AreEqual(0, variant.Index);
            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());
            Assert.AreEqual(item, (T1)variant);

        }

        [TestMethod]
        public void Variant1EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1> variant11 = item1;
            Variant<T1> variant12 = item1;
            Variant<T1> variant21 = item2;
            Variant<T1> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant1PatternMatchTest1()
        {
            Variant<T1> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            }
        }

    }
    class T2 { }

    class DerivedFromT2 : T2 { }

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
        public void Variant2TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant2EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2> variant11 = item1;
            Variant<T1, T2> variant12 = item1;
            Variant<T1, T2> variant21 = item2;
            Variant<T1, T2> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant2PatternMatchTest1()
        {
            Variant<T1, T2> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant2TestMake2()
        {
            var variant = Variant<int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant2TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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

        [TestMethod]
        public void Variant2EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2> variant11 = item1;
            Variant<T1, T2> variant12 = item1;
            Variant<T1, T2> variant21 = item2;
            Variant<T1, T2> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant2PatternMatchTest2()
        {
            Variant<T1, T2> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            }
        }

    }
    class T3 { }

    class DerivedFromT3 : T3 { }

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
        public void Variant3TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant3EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3> variant11 = item1;
            Variant<T1, T2, T3> variant12 = item1;
            Variant<T1, T2, T3> variant21 = item2;
            Variant<T1, T2, T3> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant3PatternMatchTest1()
        {
            Variant<T1, T2, T3> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant3TestMake2()
        {
            var variant = Variant<int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant3TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant3EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3> variant11 = item1;
            Variant<T1, T2, T3> variant12 = item1;
            Variant<T1, T2, T3> variant21 = item2;
            Variant<T1, T2, T3> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant3PatternMatchTest2()
        {
            Variant<T1, T2, T3> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant3TestMake3()
        {
            var variant = Variant<int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant3TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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

        [TestMethod]
        public void Variant3EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3> variant11 = item1;
            Variant<T1, T2, T3> variant12 = item1;
            Variant<T1, T2, T3> variant21 = item2;
            Variant<T1, T2, T3> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant3PatternMatchTest3()
        {
            Variant<T1, T2, T3> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            }
        }

    }
    class T4 { }

    class DerivedFromT4 : T4 { }

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
        public void Variant4TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant4EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3, T4> variant11 = item1;
            Variant<T1, T2, T3, T4> variant12 = item1;
            Variant<T1, T2, T3, T4> variant21 = item2;
            Variant<T1, T2, T3, T4> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant4PatternMatchTest1()
        {
            Variant<T1, T2, T3, T4> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant4TestMake2()
        {
            var variant = Variant<int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant4EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3, T4> variant11 = item1;
            Variant<T1, T2, T3, T4> variant12 = item1;
            Variant<T1, T2, T3, T4> variant21 = item2;
            Variant<T1, T2, T3, T4> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant4PatternMatchTest2()
        {
            Variant<T1, T2, T3, T4> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant4TestMake3()
        {
            var variant = Variant<int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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
        public void Variant4EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3, T4> variant11 = item1;
            Variant<T1, T2, T3, T4> variant12 = item1;
            Variant<T1, T2, T3, T4> variant21 = item2;
            Variant<T1, T2, T3, T4> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant4PatternMatchTest3()
        {
            Variant<T1, T2, T3, T4> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            case T4 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant4TestMake4()
        {
            var variant = Variant<int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant4TestPolymorphism4()
        {
            var item = new DerivedFromT4();
            Variant<T1, T2, T3, T4> variant = item;

            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT4>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT4>());
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

        [TestMethod]
        public void Variant4EqualsTest4()
        {
            var item1 = new T1();
            var item2 = new T4();

            Variant<T1, T2, T3, T4> variant11 = item1;
            Variant<T1, T2, T3, T4> variant12 = item1;
            Variant<T1, T2, T3, T4> variant21 = item2;
            Variant<T1, T2, T3, T4> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T4)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant4PatternMatchTest4()
        {
            Variant<T1, T2, T3, T4> variant = new T4();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: break;
            }
        }

    }
    class T5 { }

    class DerivedFromT5 : T5 { }

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
        public void Variant5TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant5EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3, T4, T5> variant11 = item1;
            Variant<T1, T2, T3, T4, T5> variant12 = item1;
            Variant<T1, T2, T3, T4, T5> variant21 = item2;
            Variant<T1, T2, T3, T4, T5> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant5PatternMatchTest1()
        {
            Variant<T1, T2, T3, T4, T5> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant5TestMake2()
        {
            var variant = Variant<int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant5EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3, T4, T5> variant11 = item1;
            Variant<T1, T2, T3, T4, T5> variant12 = item1;
            Variant<T1, T2, T3, T4, T5> variant21 = item2;
            Variant<T1, T2, T3, T4, T5> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant5PatternMatchTest2()
        {
            Variant<T1, T2, T3, T4, T5> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant5TestMake3()
        {
            var variant = Variant<int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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
        public void Variant5EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3, T4, T5> variant11 = item1;
            Variant<T1, T2, T3, T4, T5> variant12 = item1;
            Variant<T1, T2, T3, T4, T5> variant21 = item2;
            Variant<T1, T2, T3, T4, T5> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant5PatternMatchTest3()
        {
            Variant<T1, T2, T3, T4, T5> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant5TestMake4()
        {
            var variant = Variant<int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestPolymorphism4()
        {
            var item = new DerivedFromT4();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT4>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT4>());
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
        public void Variant5EqualsTest4()
        {
            var item1 = new T1();
            var item2 = new T4();

            Variant<T1, T2, T3, T4, T5> variant11 = item1;
            Variant<T1, T2, T3, T4, T5> variant12 = item1;
            Variant<T1, T2, T3, T4, T5> variant21 = item2;
            Variant<T1, T2, T3, T4, T5> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T4)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant5PatternMatchTest4()
        {
            Variant<T1, T2, T3, T4, T5> variant = new T4();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: break;
            case T5 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant5TestMake5()
        {
            var variant = Variant<int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant5TestPolymorphism5()
        {
            var item = new DerivedFromT5();
            Variant<T1, T2, T3, T4, T5> variant = item;

            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT5>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT5>());
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

        [TestMethod]
        public void Variant5EqualsTest5()
        {
            var item1 = new T1();
            var item2 = new T5();

            Variant<T1, T2, T3, T4, T5> variant11 = item1;
            Variant<T1, T2, T3, T4, T5> variant12 = item1;
            Variant<T1, T2, T3, T4, T5> variant21 = item2;
            Variant<T1, T2, T3, T4, T5> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T5)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant5PatternMatchTest5()
        {
            Variant<T1, T2, T3, T4, T5> variant = new T5();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: break;
            }
        }

    }
    class T6 { }

    class DerivedFromT6 : T6 { }

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
        public void Variant6TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant6EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest1()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant6TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant6EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest2()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant6TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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
        public void Variant6EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest3()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant6TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestPolymorphism4()
        {
            var item = new DerivedFromT4();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT4>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT4>());
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
        public void Variant6EqualsTest4()
        {
            var item1 = new T1();
            var item2 = new T4();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T4)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest4()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T4();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant6TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestPolymorphism5()
        {
            var item = new DerivedFromT5();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT5>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT5>());
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
        public void Variant6EqualsTest5()
        {
            var item1 = new T1();
            var item2 = new T5();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T5)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest5()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T5();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: break;
            case T6 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant6TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant6TestPolymorphism6()
        {
            var item = new DerivedFromT6();
            Variant<T1, T2, T3, T4, T5, T6> variant = item;

            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT6>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT6>());
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

        [TestMethod]
        public void Variant6EqualsTest6()
        {
            var item1 = new T1();
            var item2 = new T6();

            Variant<T1, T2, T3, T4, T5, T6> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T6)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant6PatternMatchTest6()
        {
            Variant<T1, T2, T3, T4, T5, T6> variant = new T6();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: break;
            }
        }

    }
    class T7 { }

    class DerivedFromT7 : T7 { }

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
        public void Variant7TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant7EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest1()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant7EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest2()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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
        public void Variant7EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest3()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism4()
        {
            var item = new DerivedFromT4();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT4>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT4>());
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
        public void Variant7EqualsTest4()
        {
            var item1 = new T1();
            var item2 = new T4();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T4)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest4()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T4();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism5()
        {
            var item = new DerivedFromT5();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT5>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT5>());
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
        public void Variant7EqualsTest5()
        {
            var item1 = new T1();
            var item2 = new T5();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T5)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest5()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T5();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism6()
        {
            var item = new DerivedFromT6();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT6>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT6>());
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
        public void Variant7EqualsTest6()
        {
            var item1 = new T1();
            var item2 = new T6();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T6)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest6()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T6();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: break;
            case T7 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant7TestMake7()
        {
            var variant = Variant<int, int, int, int, int, int, int>.Make7(42);

            Assert.AreEqual(6, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant7TestPolymorphism7()
        {
            var item = new DerivedFromT7();
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = item;

            Assert.IsTrue(variant.Is<T7>());
            Assert.AreEqual(item, variant.Get<T7>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT7>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT7>());
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

        [TestMethod]
        public void Variant7EqualsTest7()
        {
            var item1 = new T1();
            var item2 = new T7();

            Variant<T1, T2, T3, T4, T5, T6, T7> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T7)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant7PatternMatchTest7()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7> variant = new T7();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: break;
            }
        }

    }
    class T8 { }

    class DerivedFromT8 : T8 { }

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
        public void Variant8TestPolymorphism1()
        {
            var item = new DerivedFromT1();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T1>());
            Assert.AreEqual(item, variant.Get<T1>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT1>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT1>());
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
        public void Variant8EqualsTest1()
        {
            var item1 = new T1();
            var item2 = new T1();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T1)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest1()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T1();

            switch (variant.Get())
            {
            case T1 _: break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake2()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make2(42);

            Assert.AreEqual(1, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism2()
        {
            var item = new DerivedFromT2();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T2>());
            Assert.AreEqual(item, variant.Get<T2>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT2>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT2>());
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
        public void Variant8EqualsTest2()
        {
            var item1 = new T1();
            var item2 = new T2();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T2)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest2()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T2();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake3()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make3(42);

            Assert.AreEqual(2, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism3()
        {
            var item = new DerivedFromT3();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T3>());
            Assert.AreEqual(item, variant.Get<T3>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT3>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT3>());
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
        public void Variant8EqualsTest3()
        {
            var item1 = new T1();
            var item2 = new T3();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T3)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest3()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T3();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake4()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make4(42);

            Assert.AreEqual(3, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism4()
        {
            var item = new DerivedFromT4();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T4>());
            Assert.AreEqual(item, variant.Get<T4>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT4>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT4>());
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
        public void Variant8EqualsTest4()
        {
            var item1 = new T1();
            var item2 = new T4();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T4)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest4()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T4();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake5()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make5(42);

            Assert.AreEqual(4, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism5()
        {
            var item = new DerivedFromT5();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T5>());
            Assert.AreEqual(item, variant.Get<T5>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT5>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT5>());
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
        public void Variant8EqualsTest5()
        {
            var item1 = new T1();
            var item2 = new T5();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T5)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest5()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T5();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake6()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make6(42);

            Assert.AreEqual(5, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism6()
        {
            var item = new DerivedFromT6();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T6>());
            Assert.AreEqual(item, variant.Get<T6>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT6>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT6>());
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
        public void Variant8EqualsTest6()
        {
            var item1 = new T1();
            var item2 = new T6();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T6)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest6()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T6();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: break;
            case T7 _: Assert.Fail();  break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake7()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make7(42);

            Assert.AreEqual(6, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism7()
        {
            var item = new DerivedFromT7();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T7>());
            Assert.AreEqual(item, variant.Get<T7>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT7>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT7>());
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
        public void Variant8EqualsTest7()
        {
            var item1 = new T1();
            var item2 = new T7();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T7)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest7()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T7();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: break;
            case T8 _: Assert.Fail();  break;
            }
        }

        [TestMethod]
        public void Variant8TestMake8()
        {
            var variant = Variant<int, int, int, int, int, int, int, int>.Make8(42);

            Assert.AreEqual(7, variant.Index);
            Assert.AreEqual(42, variant.Get<int>());
        }

        [TestMethod]
        public void Variant8TestPolymorphism8()
        {
            var item = new DerivedFromT8();
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = item;

            Assert.IsTrue(variant.Is<T8>());
            Assert.AreEqual(item, variant.Get<T8>());

            // Should only be able to get on of the variant's generic types
            Assert.IsFalse(variant.Is<object>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<object>());
            Assert.IsFalse(variant.Is<DerivedFromT8>());
            Assert.ThrowsException<InvalidCastException>(() => variant.Get<DerivedFromT8>());
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

        [TestMethod]
        public void Variant8EqualsTest8()
        {
            var item1 = new T1();
            var item2 = new T8();

            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant11 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant12 = item1;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant21 = item2;
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant22 = item2;

            Assert.IsTrue(variant11.Equals(variant12));
            Assert.IsFalse(variant11.Equals(variant21));

            Assert.IsTrue(variant21.Equals(variant22));
            Assert.IsTrue(variant22.Equals(variant21));

            Assert.IsFalse(variant21.Equals(item2));
            Assert.IsFalse(item2.Equals(variant21));

            Assert.IsTrue(item2.Equals((T8)variant21));

            Assert.IsFalse(item1.Equals(null));
        }

        [TestMethod]
        public void Variant8PatternMatchTest8()
        {
            Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant = new T8();

            switch (variant.Get())
            {
            case T1 _: Assert.Fail();  break;
            case T2 _: Assert.Fail();  break;
            case T3 _: Assert.Fail();  break;
            case T4 _: Assert.Fail();  break;
            case T5 _: Assert.Fail();  break;
            case T6 _: Assert.Fail();  break;
            case T7 _: Assert.Fail();  break;
            case T8 _: break;
            }
        }

    }
}
