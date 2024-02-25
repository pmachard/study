
using Math.implem;
using Math.@interface;
using Model.implem;
using Model.@interface;
using Model.nterface;


namespace ModelTests
{
    [TestClass]
    public class HitBoxTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
            IHitBox hitBox = new HitBox();

            Assert.AreEqual(hitBox.CS, new CoordSystem());
            Assert.AreEqual(hitBox.L, 1.0);
            Assert.AreEqual(hitBox.W, 1.0);
            Assert.AreEqual(hitBox.H, 1.0);
        }

        [TestMethod]
        public void TestCreateWithValues()
        {
            ICoordSystem cs = new CoordSystem();
            IHitBox hitBox = new HitBox(cs,2.0,4.0,8.0);

            Assert.AreEqual(hitBox.CS, cs);
            Assert.AreEqual(hitBox.L, 2.0);
            Assert.AreEqual(hitBox.H, 4.0);
            Assert.AreEqual(hitBox.W, 8.0);
        }

        [TestMethod]
        public void TestGetPoint()
        {
            ICoordSystem cs = new CoordSystem();
            IHitBox hitBox = new HitBox(cs, 2.0, 4.0, 8.0);

            List<ICoord3D> points = hitBox.GetPtsLocal();

            Assert.AreEqual(points.Count(), 8);

            Assert.AreEqual(points[0], new Coord3D(1.0, 2.0, 4.0));
            Assert.AreEqual(points[1], new Coord3D(1.0, -2.0, 4.0));
            Assert.AreEqual(points[2], new Coord3D(-1.0, -2.0, 4.0));
            Assert.AreEqual(points[3], new Coord3D(-1.0, 2.0, 4.0));

            Assert.AreEqual(points[0], new Coord3D(1.0, 2.0, -4.0));
            Assert.AreEqual(points[1], new Coord3D(1.0, -2.0, -4.0));
            Assert.AreEqual(points[2], new Coord3D(-1.0, -2.0, -4.0));
            Assert.AreEqual(points[3], new Coord3D(-1.0, 2.0, -4.0));
        }
    }
}
