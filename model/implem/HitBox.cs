using Math.@interface;
using Math.implem;
using Model.@interface;
using System.Collections.Generic;

namespace Model.implem
{
    public class HitBox : IHitBox
    {

        public HitBox()
        {
            L = W = H = 1.0;
            CS = new CoordSystem();
            Name = "";
        }

        public HitBox(ICoordSystem cs, double l, double h, double w)
        {
            L = l;
            H = h;
            W = w;

            CS = cs;
            Name = "";
        }

        public double L { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public ICoordSystem CS { get; set; }
        public string Name { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            throw new NotImplementedException();
        }

        public List<ICoord3D> GetPtsLocal()
        {
            List<ICoord3D> points = new List<ICoord3D>();

            points.Add(new Coord3D(L / 2.0, H / 2.0, W / 2.0));
            points.Add(new Coord3D(L / 2.0, -H / 2.0, W / 2.0));
            points.Add(new Coord3D(-L / 2.0, -H / 2.0, W / 2.0));
            points.Add(new Coord3D(-L / 2.0, H / 2.0, W / 2.0));

            points.Add(new Coord3D(L / 2.0, H / 2.0, -W / 2.0));
            points.Add(new Coord3D(L / 2.0, -H / 2.0, -W / 2.0));
            points.Add(new Coord3D(-L / 2.0, -H / 2.0, -W / 2.0));
            points.Add(new Coord3D(-L / 2.0, H / 2.0, -W / 2.0));

            return points;
        }

        public List<ICoord3D> GetPtsAbsolute()
        {
            List<ICoord3D> points = GetPtsLocal();

            points = CS.Transform(points);
            return points;
        }
    }
}