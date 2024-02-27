using Math.@interface;
using Math.implem;


namespace MathTests
{
    [TestClass]
    public class CoordSystemTests
    {
        [TestMethod]
        void testIsNormal1()
        {
            ICoord3D O = new Coord3D(0.0, 0.0, 0.0);
            ICoord3D I = new Coord3D(1.0, 0.0, 0.0);
            ICoord3D J = new Coord3D(0.0, 1.0, 0.0);
            ICoord3D K = new Coord3D(0.0, 0.0, 1.0);

            ICoordSystem cs_unit = new CoordSystem(O, I, J, K);

            Assert.IsTrue(cs_unit.IsNormal());
        }

        [TestMethod]
        void testIsNormal2()
        {
            ICoord3D O = new Coord3D(0.0, 0.0, 0.0);
            ICoord3D I = new Coord3D(1.0, 0.0, 0.0);
            ICoord3D J = new Coord3D(0.0, 1.0, 0.0);
            ICoord3D K = new Coord3D(0.0, 0.0, 1.0);

            ICoordSystem csBad = new CoordSystem(O, I, J, K);

            Assert.IsFalse(csBad.IsNormal());
        }

        [TestMethod]
        void testTranform01()
        {
            ICoord3D O = new Coord3D(10.0, 20.0, 30.0);
            ICoord3D I = new Coord3D(1.0, 0.0, 0.0);
            ICoord3D J = new Coord3D(0.0, 1.0, 0.0);
            ICoord3D K = new Coord3D(0.0, 0.0, 1.0);

            ICoordSystem cs_unit_trans_1 = new CoordSystem(O, I, J, K);

            ICoord3D pt = new Coord3D(1.0, 2.0, 3.0);
            ICoord3D ptTranform = cs_unit_trans_1.Transform(pt);

            Assert.AreEqual(ptTranform, new Coord3D(11.0, 22.0, 33.0));

        }
    }
}