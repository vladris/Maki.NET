using Maki.Functional;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class FunctionExtensionsTest
    {
        [TestMethod]
        public void Func2CurryTransformTest()
        {
            Func<int, int, int> func =
                (i1, i2) 
                    => i1 + i2;

            int sum = func.Curry()(1)(2);

            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        public void Func2CurryApplyTest()
        {
            Func<int, int, int> func =
                (i1, i2) 
                    => i1 + i2;

            int sum = func.Curry(1)(2);

            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        public void Func3CurryTransformTest()
        {
            Func<int, int, int, int> func =
                (i1, i2, i3) 
                    => i1 + i2 + i3;

            int sum = func.Curry()(1)(2)(3);

            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void Func3CurryApplyTest()
        {
            Func<int, int, int, int> func =
                (i1, i2, i3) 
                    => i1 + i2 + i3;

            int sum = func.Curry(1).Curry(2)(3);

            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void Func4CurryTransformTest()
        {
            Func<int, int, int, int, int> func =
                (i1, i2, i3, i4) 
                    => i1 + i2 + i3 + i4;

            int sum = func.Curry()(1)(2)(3)(4);

            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void Func4CurryApplyTest()
        {
            Func<int, int, int, int, int> func =
                (i1, i2, i3, i4) 
                    => i1 + i2 + i3 + i4;

            int sum = func.Curry(1).Curry(2).Curry(3)(4);

            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void Func5CurryTransformTest()
        {
            Func<int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5) 
                    => i1 + i2 + i3 + i4 + i5;

            int sum = func.Curry()(1)(2)(3)(4)(5);

            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void Func5CurryApplyTest()
        {
            Func<int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5) 
                    => i1 + i2 + i3 + i4 + i5;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4)(5);

            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void Func6CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6) 
                    => i1 + i2 + i3 + i4 + i5 + i6;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6);

            Assert.AreEqual(21, sum);
        }

        [TestMethod]
        public void Func6CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6) 
                    => i1 + i2 + i3 + i4 + i5 + i6;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5)(6);

            Assert.AreEqual(21, sum);
        }

        [TestMethod]
        public void Func7CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7);

            Assert.AreEqual(28, sum);
        }

        [TestMethod]
        public void Func7CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6)(7);

            Assert.AreEqual(28, sum);
        }

        [TestMethod]
        public void Func8CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8);

            Assert.AreEqual(36, sum);
        }

        [TestMethod]
        public void Func8CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7)(8);

            Assert.AreEqual(36, sum);
        }

        [TestMethod]
        public void Func9CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9);

            Assert.AreEqual(45, sum);
        }

        [TestMethod]
        public void Func9CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8)(9);

            Assert.AreEqual(45, sum);
        }

        [TestMethod]
        public void Func10CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            Assert.AreEqual(55, sum);
        }

        [TestMethod]
        public void Func10CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9)(10);

            Assert.AreEqual(55, sum);
        }

        [TestMethod]
        public void Func11CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            Assert.AreEqual(66, sum);
        }

        [TestMethod]
        public void Func11CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10)(11);

            Assert.AreEqual(66, sum);
        }

        [TestMethod]
        public void Func12CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            Assert.AreEqual(78, sum);
        }

        [TestMethod]
        public void Func12CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10).Curry(11)(12);

            Assert.AreEqual(78, sum);
        }

        [TestMethod]
        public void Func13CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            Assert.AreEqual(91, sum);
        }

        [TestMethod]
        public void Func13CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10).Curry(11).Curry(12)(13);

            Assert.AreEqual(91, sum);
        }

        [TestMethod]
        public void Func14CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            Assert.AreEqual(105, sum);
        }

        [TestMethod]
        public void Func14CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10).Curry(11).Curry(12).Curry(13)(14);

            Assert.AreEqual(105, sum);
        }

        [TestMethod]
        public void Func15CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            Assert.AreEqual(120, sum);
        }

        [TestMethod]
        public void Func15CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10).Curry(11).Curry(12).Curry(13).Curry(14)(15);

            Assert.AreEqual(120, sum);
        }

        [TestMethod]
        public void Func16CurryTransformTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16;

            int sum = func.Curry()(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)(16);

            Assert.AreEqual(136, sum);
        }

        [TestMethod]
        public void Func16CurryApplyTest()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func =
                (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) 
                    => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16;

            int sum = func.Curry(1).Curry(2).Curry(3).Curry(4).Curry(5).Curry(6).Curry(7).Curry(8).Curry(9).Curry(10).Curry(11).Curry(12).Curry(13).Curry(14).Curry(15)(16);

            Assert.AreEqual(136, sum);
        }

    }
}