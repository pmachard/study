
using Math.implem;
using Math.@interface;
using Model.implem;
using Model.@interface;
using Model.nterface;


namespace ModelTests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
            ISphere sphere = new Sphere("S1");

            Assert.AreEqual(sphere.Name, "S1");
            Assert.AreEqual(sphere.Radius, 1.0);

            ICoordSystem cs = sphere.CS;
            Assert.AreEqual(cs.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(cs.I, new Coord3D(1.0, 0.0, 0.0));
            Assert.AreEqual(cs.J, new Coord3D(0.0, 1.0, 0.0));
            Assert.AreEqual(cs.K, new Coord3D(0.0, 0.0, 1.0));

            IHitBox hitBox = sphere.GetHitBox();
            Assert.AreEqual(hitBox.L, 1.0);
            Assert.AreEqual(hitBox.W, 1.0);
            Assert.AreEqual(hitBox.H, 1.0);
        }


        [TestMethod]
        public void TestCreateInter()
        {
            ISphere sphere = new Sphere("S1");

            IRay ray = new Ray( new Coord3D(0.0, 0.0, -10.0),
                                new Coord3D(0.0, 0.0, 1.0));
            IInterPoint interPoint = sphere.Compute(ray);
            Assert.IsNotNull(interPoint);
        }
    }
}
