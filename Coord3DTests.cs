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
  }
}
