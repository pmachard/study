using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class Cylinder : ICylinder
    {
        public Cylinder()
        {
            LocalCoordSystem = new CoordSystem();
            Radius = 1.0;
            Height = 1.0;
        }
        public Cylinder(ICoordSystem localCoordSystem, double radius, double height)
        {
            LocalCoordSystem = localCoordSystem;
            Radius = radius;
            Height = height;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public ICoordSystem LocalCoordSystem { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            throw new NotImplementedException();
        }
    }
}