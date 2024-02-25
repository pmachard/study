
using Math.implem;
using Model.implem;
using Model.nterface;


namespace ModelTests
{
    [TestClass]
    public class RayTracerTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
            IRayTracer raytracer = new RayTracer();
          
            Assert.IsTrue(raytracer.CS.Equals(new CoordSystem()));
            Assert.IsTrue(raytracer.Camera.CS.Equals(new CoordSystem()));
        }

    }
}
