
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Math.@interface;
using Math.implem;


namespace MathTests
{
    [TestClass]
    public class Mat3x3Tests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
          IMat m= new Mat3x3();
          Assert.AreEqual(m.N, 3);
          Assert.AreEqual(m.M, 3);
        }

        [TestMethod]
        public void TestCreateDefaultCheckValue()
        {
            IMat m = new Mat3x3();
            Assert.AreEqual(m.get(1, 1), 0.0);
            Assert.AreEqual(m.get(1, 2), 0.0);
            Assert.AreEqual(m.get(1, 3), 0.0);

            Assert.AreEqual(m.get(2, 1), 0.0);
            Assert.AreEqual(m.get(2, 2), 0.0);
            Assert.AreEqual(m.get(2, 3), 0.0);

            Assert.AreEqual(m.get(3, 1), 0.0);
            Assert.AreEqual(m.get(3, 2), 0.0);
            Assert.AreEqual(m.get(3, 3), 0.0);
        }

        [TestMethod]
        public void TestCreateUnit()
        {
            IMat m = Mat3x3.Unit();

            Assert.AreEqual(m.get(1, 1), 1.0);
            Assert.AreEqual(m.get(1, 2), 0.0);
            Assert.AreEqual(m.get(1, 3), 0.0);

            Assert.AreEqual(m.get(2, 1), 0.0);
            Assert.AreEqual(m.get(2, 2), 1.0);
            Assert.AreEqual(m.get(2, 3), 0.0);

            Assert.AreEqual(m.get(3, 1), 0.0);
            Assert.AreEqual(m.get(3, 2), 0.0);
            Assert.AreEqual(m.get(3, 3), 1.0);
        }

    }
}
