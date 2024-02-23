using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    public class Ray : IRay
    {
        public Ray()
        {
            O = new Coord3D();
            V = new Coord3D();
            LocalCoordSystem = new CoordSystem();
        }
        public Ray(ICoord3D o, ICoord3D v)
        {
            O = o;
            V = v;
            LocalCoordSystem = new CoordSystem();
        }

        public ICoord3D O { get; set; }
        public ICoord3D V { get; set; }
        public ICoordSystem LocalCoordSystem { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            O = O + v;
        }
    }
}