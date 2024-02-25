
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

            Assert.AreEqual(I.Norme(), 1.0);
            Assert.AreEqual(J.Norme(), 1.0);
            Assert.AreEqual(K.Norme(), 1.0);


            ICoordSystem cs = new CoordSystem(O, I, J, K);

            Assert.IsTrue(cs.IsNormal());
        }
    }
}