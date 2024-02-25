
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Math.@interface;
using Math.implem;


namespace MathTests
{
    [TestClass]
    public class Coord3DTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
          Coord3D c= new Coord3D();
          Assert.AreEqual(c.X, 0.0);
          Assert.AreEqual(c.Y, 0.0);
          Assert.AreEqual(c.Z, 0.0);
        }

        [TestMethod]
        public void TestCreateWithInit()
        {
          Coord3D c = new Coord3D(1.0,2.0,3.0);
          Assert.AreEqual(c.X, 1.0);
          Assert.AreEqual(c.Y, 2.0);
          Assert.AreEqual(c.Z, 3.0);
        }

        [TestMethod]
        public void TestAdd()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          ICoord3D c2 = new Coord3D(0.5,0.6,0.7);

          ICoord3D c3 = c1 + c2;

          Assert.AreEqual(c3.X, 1.5);
          Assert.AreEqual(c3.Y, 2.6);
          Assert.AreEqual(c3.Z, 3.7);
        }
        
        [TestMethod]
        public void TestSupp()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          ICoord3D c2 = new Coord3D(0.5,0.6,0.7);

          ICoord3D c3 = c1 - c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 1.4);
          Assert.AreEqual(c3.Z, 2.3);
        }
        
        [TestMethod]
        public void TestInvers()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          ICoord3D c3 = -c1;

          Assert.AreEqual(c3.X, -1.0);
          Assert.AreEqual(c3.Y, -2.0);
          Assert.AreEqual(c3.Z, -3.0);
        }
        
        [TestMethod]
        public void TestMult()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          double coef = 2.0;
          ICoord3D c3 = c1 * coef;

          Assert.AreEqual(c3.X, 2.0);
          Assert.AreEqual(c3.Y, 4.0);
          Assert.AreEqual(c3.Z, 6.0);
        }

        [TestMethod]
        public void TestMultCoord()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          ICoord3D c2 = new Coord3D(0.5,2.0,5.0);

          ICoord3D c3 = c1 * c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 4.0);
          Assert.AreEqual(c3.Z, 15.0);
        }
        
      [TestMethod]
        public void TestRaport()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          double coef = 2.0;
          ICoord3D c3 = c1 / coef;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 1.0);
          Assert.AreEqual(c3.Z, 1.5);
        }

        [TestMethod]
        public void TestDiv()
        {
          ICoord3D c1 = new Coord3D(1.0,2.0,3.0);
          ICoord3D c2 = new Coord3D(2.0,1.0,3.0);
          ICoord3D c3 = c1 / c2;

          Assert.AreEqual(c3.X, 0.5);
          Assert.AreEqual(c3.Y, 2.0);
          Assert.AreEqual(c3.Z, 1.0);
        }
        
        [TestMethod]
        public void TestIsProportionalNull()
        {
          ICoord3D c1 = new Coord3D(0.0,0.0,0.0);
          ICoord3D c2 = new Coord3D(0.0,0.0,0.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
               
        [TestMethod]
        public void TestIsProportionalExp1()
        {
          Coord3D c1 = new Coord3D(1.0,2.0,4.0);
          Coord3D c2 = new Coord3D(2.0,4.0,8.0);
          Assert.AreEqual(c1.IsProportional(c2),true);
        }
        
        [TestMethod]
        public void TestIsProportionalExp2()
        {
          Coord3D c1 = new Coord3D(1.0,2.0,4.0);
          Coord3D c2 = new Coord3D(3.0,3.0,3.0);
          Assert.AreEqual(c1.IsProportional(c2),false);
        }
        
        [TestMethod]
        public void TestSwap()
        {
            Coord3D c1 = new Coord3D(1.0,2.0,3.0);
            ICoord3D c2 = c1.swap();
            Assert.AreEqual(c2.X, c1.Z);
            Assert.AreEqual(c2.Y, c1.Y);
            Assert.AreEqual(c2.Z, c1.X);
        }
        [TestMethod]
        public  void TestNormalBasic()
        { 
            Assert.AreEqual((new Coord3D(1.0,0.0,0.0)).Norme(),               
            Assert.AreEqual((new Coord3D(0.0,1.0,0.0)).Norme());
            Assert.AreEqual((new Coord3D(0.0,0.0,1.0)));
        }
    }
}
Assert.AreEqual((new Coord3D(1.0,0.0,0.0)).Norme(),1.0);