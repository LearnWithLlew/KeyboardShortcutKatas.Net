﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KeyboardShortcutKatas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var r = new Inline().Practice();
            Assert.AreEqual(42, r);
        }
    }
}
