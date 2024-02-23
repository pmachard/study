using Math.@interface;
using Math.implem;

using Model.@interface;

namespace Model.implem
{
    class Cube : ICube
    {
        public Cube()
        {
            LocalCoordSystem = new CoordSystem();
            Size = 1.0;
        }

        public Cube(ICoordSystem coordSystem, double size)
        {
            LocalCoordSystem = coordSystem;
            Size = size;
        }

        public ICoordSystem LocalCoordSystem { get; set; }
        public double Size { get; set; }

        public void RunTranlation(ICoord3D v)
        {

            LocalCoordSystem.O = LocalCoordSystem.O + v;
        }
    }
}