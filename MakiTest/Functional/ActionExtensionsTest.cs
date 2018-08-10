using Maki.Functional;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MakiTest
{
    [TestClass]
    public class ActionExtensionsTest
    {
        [TestMethod]
        public void ActionToFuncTest()
        {
            bool called = false;
            Action act = () => { called = true; };

            var func = act.ToFunc();
            func();

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action1ToFuncTest()
        {
            bool called = false;
            Action<int> act =
                (_1) => { called = true; };

            var func = act.ToFunc();
            func(1);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action2ToFuncTest()
        {
            bool called = false;
            Action<int, int> act =
                (_1, _2) => { called = true; };

            var func = act.ToFunc();
            func(1, 2);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action3ToFuncTest()
        {
            bool called = false;
            Action<int, int, int> act =
                (_1, _2, _3) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action4ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int> act =
                (_1, _2, _3, _4) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action5ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int> act =
                (_1, _2, _3, _4, _5) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action6ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action7ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action8ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action9ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action10ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action11ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action12ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action13ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action14ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action15ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            Assert.IsTrue(called);
        }

        [TestMethod]
        public void Action16ToFuncTest()
        {
            bool called = false;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> act =
                (_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16) => { called = true; };

            var func = act.ToFunc();
            func(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.IsTrue(called);
        }

    }
}