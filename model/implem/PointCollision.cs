using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    class PointCollision : IPointCollision
    {
        public PointCollision()
        {
            Point = new Coord3D();
            Normal = new Coord3D();
            Distance = 0.0;
        }

        public PointCollision(ICoord3D p, ICoord3D n, double d)
        {
            Point = p;
            Normal = n;
            Distance = d;
        }


        public ICoord3D Point { get; set; }
        public ICoord3D Normal { get; set; }
        public double Distance { get; set; }


    }

}
