using Math.@interface;
using Math.implem;

using Model.@interface;
using Model.nterface;

namespace Model.implem
{

    public class Sphere : ISphere
    {
        public Sphere(string name="")
        {
            CS = new CoordSystem();
            Radius = 1.0;
            Name = name;
        }

        public Sphere(ICoordSystem cs, string name, double r)
        {
            CS = cs;
            Radius = r;
            Name = name;
        }

        public double Radius { get; set; }
        public ICoordSystem CS { get; set; }
        public string Name { get; set; }

        public IHitBox GetHitBox()
        {
            return new HitBox(CS, Radius, Radius, Radius);
        }

        public void RunTranlation(ICoord3D v)
        {
            CS.O = CS.O + v;
        }

    }
}