using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    public class Cube : ICube
    {
        public Cube(string name="")
        {
            CS = new CoordSystem();
            Name = name;
            Size = 1.0;
            Mat = new Material();
        }

        public Cube(ICoordSystem coordSystem, string name,double size)
        {
            CS = coordSystem;
            Name = name;
            Size = size;
            Mat = new Material();
            }

        public ICoordSystem CS { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public IMaterial Mat { get ; set ; }

        public IInterPoint CloserPoint(List<IInterPoint> points)
        {
            double distanceMax = double.PositiveInfinity;
            IInterPoint pointMin = new InterPoint();
            foreach (IInterPoint point in points)
            {
                if (distanceMax > point.D)
                {
                    distanceMax = point.D;
                    pointMin = point;
                }
            }
            return pointMin;
        }

        public IInterPoint Compute(IRay ray)
        {
            return CloserPoint(GetHitBox().Collision(ray));
        }

        public IHitBox GetHitBox()
        {
            return new HitBox(CS, Size, Size, Size);
        }

        public void RunTranlation(ICoord3D v)
        {
            CS.O = CS.O + v;
        }
    }
}