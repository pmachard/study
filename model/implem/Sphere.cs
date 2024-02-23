using Math.@interface;
using Math.implem;

using Model.@interface;
using Model.nterface;

namespace Model.implem
{

    public class Sphere : ISphere
    {
        public Sphere()
        {
            LocalCoordSystem = new CoordSystem();
            Radius = 1.0;
        }

        public Sphere(ICoordSystem cs, double r)
        {
            LocalCoordSystem = cs;
            Radius = r;
        }

        public double Radius { get; set; }

        public ICoordSystem LocalCoordSystem { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            LocalCoordSystem.O = LocalCoordSystem.O + v;
        }

    }
}