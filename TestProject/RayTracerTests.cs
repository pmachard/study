
using Math.implem;
using Model.implem;
using Model.@interface;
using Model.nterface;


namespace ModelTests
{
    [TestClass]
    public class RayTracerTests
    {
        private IRayTracer _raytracer;

        public RayTracerTests() 
        {
            _raytracer = new RayTracer();
            _raytracer.CS = new CoordSystem();
            _raytracer.Camera = new CameraRay();

            _raytracer.Camera.CS = new CoordSystem(
                new Coord3D(0.0, 0.0, -10.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0));
        }

        [TestMethod]
        public void TestCreateDefault()
        {
            IRayTracer raytracer = new RayTracer();
          
            Assert.IsTrue(raytracer.CS.Equals(new CoordSystem()));
            Assert.IsTrue(raytracer.Camera.CS.Equals(new CoordSystem()));
        }

        [TestMethod]
        public void TestCreateInitLocal()
        {
            Assert.IsTrue(_raytracer.CS.Equals(new CoordSystem()));
            _raytracer.Camera.L = 4.0;
            _raytracer.Camera.H = 2.0;

            _raytracer.Camera.NbrPointL = 20;
            _raytracer.Camera.NbrPointH = 10;

            Assert.AreEqual(_raytracer.Camera.DeltaL, 0.2);
            Assert.AreEqual(_raytracer.Camera.DeltaH, 0.2);
        }

        [TestMethod]
        public void TestComputeRay()
        {
            _raytracer.Camera.CS = new CoordSystem(
                new Coord3D(0.0, 0.0, 10.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0)
                );

            _raytracer.Camera.L = 2.0;
            _raytracer.Camera.H = 1.0;
            _raytracer.Camera.NbrPointL = 20;
            _raytracer.Camera.NbrPointH = 10;

            IRay ray = _raytracer.ComputeRay(0,0);
            Assert.AreEqual(ray.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(ray.V, new Coord3D(0.0, 0.0, 10.0));

            ray = _raytracer.ComputeRay(-10, -5);
            Assert.AreEqual(ray.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(ray.V, new Coord3D(-1.0, -0.5, 10.0));

            ray = _raytracer.ComputeRay(-10, 5);
            Assert.AreEqual(ray.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(ray.V, new Coord3D(-1.0, 0.5, 10.0));

            ray = _raytracer.ComputeRay(10, 5);
            Assert.AreEqual(ray.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(ray.V, new Coord3D(1.0, 0.5, 10.0));

            ray = _raytracer.ComputeRay(10, -5);
            Assert.AreEqual(ray.O, new Coord3D(0.0, 0.0, 0.0));
            Assert.AreEqual(ray.V, new Coord3D(1.0, -0.5, 10.0));
        }

        [TestMethod]
        public void TestComputeRayAll()
        {
            _raytracer.Camera.CS = new CoordSystem(
                new Coord3D(0.0, 0.0, 10.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0)
                );

            _raytracer.Camera.L = 2.0;
            _raytracer.Camera.H = 1.0;
            _raytracer.Camera.NbrPointL = 20;
            _raytracer.Camera.NbrPointH = 10;

            for(int x = -10; x < 10; x ++)
            {
                for (int y = -5; y < 5; y++)
                {
                    IRay ray = _raytracer.ComputeRay(x, y);
                    Assert.IsNotNull(ray);
                }
            }
        }

        [TestMethod]
        public void TestCompute()
        {
            _raytracer.CS = new CoordSystem(
                new Coord3D(0.0, 0.0, 15.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0)
                );


            _raytracer.Camera.CS = new CoordSystem(
                new Coord3D(0.0, 0.0, 5.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0)
                );

            _raytracer.Light = new Light();
            _raytracer.Light.CS = new CoordSystem(
                new Coord3D(0.0, 5.0, 5.0),
                new Coord3D(1.0, 0.0, 0.0),
                new Coord3D(0.0, 1.0, 0.0),
                new Coord3D(0.0, 0.0, 1.0)
                );
            _raytracer.Light.Color = new Color(1.0, 1.0, 1.0);
            _raytracer.Light.V = new Coord3D(1.0, 1.0, 1.0);


            _raytracer.Camera.L = 2.0;
            _raytracer.Camera.H = 2.0;
            _raytracer.Camera.NbrPointL = 400;
            _raytracer.Camera.NbrPointH = 400;

            IScene scene = new Scene();

            scene.AddObject(new Sphere());

            IImage image = _raytracer.Compute(scene);
            Assert.IsNotNull(image);

            image.save("TestCompute.png");
        }
    }
}
