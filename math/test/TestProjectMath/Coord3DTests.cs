
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using math;

namespace MathTests
{
    [TestClass]
    public class Coord3DTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
          Coord3D c;
          Assert.AreEqual(c.X, 0.0);
          Assert.AreEqual(c.Y, 0.0);
          Assert.AreEqual(c.Z, 0.0);
        }

        [TestMethod]
        public void TestCreateWithInit()
        {
          Coord3D c(1.0,2.0,3.0);
          Assert.AreEqual(c.X, 1.0);
          Assert.AreEqual(c.Y, 2.0);
          Assert.AreEqual(c.Z, 3.0);
        }

        [TestMethod]
        public void TestAdd()
        {
          Coord3D c(1.0,2.0,3.0);
          Coord3D c2(0.5,0.6,0.7);

          Coord3D c3 = c1 + c2;

          Assert.AreEqual(c3.X, 1.5);
          Assert.AreEqual(c3.Y, 2.6);
          Assert.AreEqual(c3.Z, 3.7);
        }
        
        [TestMethod]
        public void TestSupp()
        {
          Coord3D c(1.0,2.0,3.0);
          Coord3D c2(0.5,0.6,0.7);

          Coord3D c3 = c1 - c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 1.4);
          Assert.AreEqual(c3.Z, 2.3);
        }
        
        [TestMethod]
        public void TestSupp()
        {
          Coord3D c(1.0,2.0,3.0);

          Coord3D c3 = -c1;

          Assert.AreEqual(c3.X, -1.0);
          Assert.AreEqual(c3.Y, -2.0);
          Assert.AreEqual(c3.Z, -3.0);
        }
        
        [TestMethod]
        public void TestMult()
        {
          Coord3D c(1.0,2.0,3.0);
          double coef = 2.0;
          Coord3D c3 = c1 * coef;

          Assert.AreEqual(c3.X, 2.0);
          Assert.AreEqual(c3.Y, 4.0);
          Assert.AreEqual(c3.Z, 6.0);
        }

        [TestMethod]
        public void TestMultCoord()
        {
          Coord3D c(1.0,2.0,3.0);
          Coord3D c2(0.5,2.0,5.0);

          Coord3D c3 = c1 * c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 4.0);
          Assert.AreEqual(c3.Z, 15.0);
        }
        
      [TestMethod]
        public void TestRaport()
        {
          Coord3D c1(1.0,2.0,3.0);
          double coef = 2.0;
          Coord3D c3 = c1 / coef;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 1.0);
          Assert.AreEqual(c3.Z, 1.5);
        }

        [TestMethod]
        public void TestDiv()
        {
          Coord3D c1(1.0,2.0,3.0);
          Coord3D c2(2.0,1.0,3.0);
          Coord3D c3 = c1 / c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 1.0);
          Assert.AreEqual(c3.Z, 1.0);
        }
        
        [TestMethod]
        public void TestIsProportionalNull()
        {
          Coord3D c1(0.0,0.0,0.0);
          Coord3D c2(0.0,0.0,0.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp1()
        {
          Coord3D c1(1.0,1.0,0.0);
          Coord3D c2(0.0,2.0,0.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp2()
        {
          Coord3D c1(1.0,0.0,1.0);
          Coord3D c2(0.0,0.0,2.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp3()
        {
          Coord3D c1(1.0,1.0,1.0);
          Coord3D c2(0.0,2.0,2.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp4()
        {
          Coord3D c1(1.0,2.0,4.0);
          Coord3D c2(2.0,4.0,8.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp5()
        {
          Coord3D c1(1.0,2.0,4.0);
          Coord3D c2(3.0,3.0,3.0);
          Assert.AreEqual(c1.IsProportional(c2),false);
        }
        
        [TestMethod]
        public void TestSwap()
        {
          Coord3D c1(1.0,2.0,4.0);
          Coord3D c2(4.0,2.0,1.0);
          Assert.AreEqual(c1.swap(),c2);
        }
  }
}
