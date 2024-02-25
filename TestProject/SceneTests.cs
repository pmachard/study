
using Math.implem;
using Model.implem;
using Model.@interface;
using Model.nterface;


namespace ModelTests
{
    [TestClass]
    public class SceneTests
    {
        [TestMethod]
        public void TestCreateDefault()
        {
            IScene scene = new Scene();
          
            Assert.IsTrue(scene.CS.Equals(new CoordSystem()));
        }

        [TestMethod]
        public void TestAddObject()
        {
            IScene scene = new Scene();

            scene.AddObject(new Cube("A"));

            Assert.AreEqual(scene.NbrObjects(), 1);
            Assert.AreEqual(scene.GetObject(0).Name, "A");

            scene.AddObject(new Cube("B"));

            Assert.AreEqual(scene.NbrObjects(), 2);
            Assert.AreEqual(scene.GetObject(1).Name, "B");
        }
    }
}
