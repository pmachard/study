using Math.@interface;
using Math.implem;
using Model.@interface;
using System.Collections.Generic;
using Model.nterface;

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

        public List<ICoord3D> GetFacette(int NumFacette)
        {
            List<ICoord3D> points = new List<ICoord3D>();

            List<ICoord3D> allPoints = GetPtsLocal();

            if ((NumFacette < 0) || (NumFacette>5))
                throw new ArgumentException();

            switch (NumFacette)
            { 
                case 0:
                    points.Add(allPoints[0]);
                    points.Add(allPoints[1]);
                    points.Add(allPoints[2]);
                    points.Add(allPoints[3]);
                    break;
                case 1:
                    points.Add(allPoints[0]);
                    points.Add(allPoints[1]);
                    points.Add(allPoints[5]);
                    points.Add(allPoints[4]);
                    break;
                case 2:
                    points.Add(allPoints[4]);
                    points.Add(allPoints[5]);
                    points.Add(allPoints[6]);
                    points.Add(allPoints[7]);
                    break;
                case 3:
                    points.Add(allPoints[7]);
                    points.Add(allPoints[6]);
                    points.Add(allPoints[2]);
                    points.Add(allPoints[3]);
                    break;
                case 4:
                    points.Add(allPoints[0]);
                    points.Add(allPoints[4]);
                    points.Add(allPoints[7]);
                    points.Add(allPoints[3]);
                    break;
                case 5:
                    points.Add(allPoints[1]);
                    points.Add(allPoints[5]);
                    points.Add(allPoints[6]);
                    points.Add(allPoints[2]);
                    break;
            }

            return points;
        }

        public List<ICoord3D> Collision(IRay ray)
        {
            List<ICoord3D> points = new List<ICoord3D>();



            return points;
        }
    }
}