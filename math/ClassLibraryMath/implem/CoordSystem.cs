using Math.@interface;

namespace Math.implem
{
    public class CoordSystem : ICoordSystem
    {
        public CoordSystem()
        {
            O = new Coord3D(0.0, 0.0, 0.0);
            I = new Coord3D(1.0, 0.0, 0.0);
            J = new Coord3D(0.0, 1.0, 0.0);
            K = new Coord3D(0.0, 0.0, 1.0);
        }

        public CoordSystem(ICoord3D o, ICoord3D i, ICoord3D j, ICoord3D k)
        {
            O = new Coord3D(o);
            I = new Coord3D(i);
            J = new Coord3D(j);
            K = new Coord3D(k);
        }

        public ICoord3D O { get; set; }
        public ICoord3D I { get; set; }
        public ICoord3D J { get; set; }
        public ICoord3D K { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            O = O + v;
        }
    }
}