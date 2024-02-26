
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Math.@interface;
using Math.implem;


namespace MathTests
{
    [TestClass]
    public class CoordSystemTests
    {

        void testIsNormal1()
        {
            ICoord3D O = new Coord3D(0.0, 0.0, 0.0);
            ICoord3D I = new Coord3D(1.0, 0.0, 0.0);
            ICoord3D J = new Coord3D(0.0, 1.0, 0.0);
            ICoord3D K = new Coord3D(0.0, 0.0, 1.0);


            ICoordSystem cs = new CoordSystem(O, I, J, K);

            Assert.IsTrue(cs.IsNormal());
        }

        void testTranform01()
        {
            ICoord3D O = new Coord3D(10.0, 20.0, 30.0);
            ICoord3D I = new Coord3D(1.0, 0.0, 0.0);
            ICoord3D J = new Coord3D(0.0, 1.0, 0.0);
            ICoord3D K = new Coord3D(0.0, 0.0, 1.0);

            ICoordSystem cs = new CoordSystem(O, I, J, K);

            ICoord3D pt = new Coord3D(1.0, 2.0, 3.0);
            ICoord3D ptTranform = cs.Transform(pt);


            Assert.AreEqual(ptTranform, new Coord3D(11.0, 22.0, 33.0));


        }
    }
}