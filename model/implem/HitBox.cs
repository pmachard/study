using Math.@interface;
using Math.implem;
using Model.@interface;
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

        public IInterPoint CollisionFacette(IRay ray,int pos)
        {
            IInterPoint pointInter = new InterPoint();

            // Récupére les point de la facette
            List<ICoord3D> pointsFacette = GetFacette(pos);

            // Calcul le vecteur normal à la facette
            ICoord3D u = pointsFacette[1] - pointsFacette[0];
            ICoord3D v = pointsFacette[3] - pointsFacette[0];
            ICoord3D w = u & v;

            // Equation cartesienne du plan
            ICoord3D o = pointsFacette[0];
            // w.x * (x-o.x) + w.y * (y-o.x) + w.z * (z-o.z)  = 0

            // Equation parametrique de de la droite
            // x = ray.O.X + ray.V.X * t
            // y = ray.O.Y + ray.V.Y * t
            // z = ray.O.Z + ray.V.Z * t

            // Resolution de l'équation
            // w.x * (ray.O.X + ray.V.X * t-o.x) + w.y * (ray.O.Y + ray.V.Y * t-o.x) + w.z * (ray.O.Z + ray.V.Z * t-o.z)  = 0
            //
            // double d = (w.X * ray.V.X + w.Y * ray.V.Y + w.Z * ray.V.Z);
            double d = w ^ ray.V;
            if (d != 0.0)
            {
                double t = -((w.X * ray.O.X + w.Y * ray.O.Y + w.Z * ray.O.Z) - (w.X * o.X + w.Y * o.Y + w.Z * o.Z)) / d;

                ICoord3D point = new Coord3D(
                    ray.O.X + ray.V.X * t,
                    ray.O.Y + ray.V.Y * t,
                    ray.O.Z + ray.V.Z * t);

                // Il faut maintenant vérifier que le point est bien a l'interieur de la facette

                // On se trouve dans le repére local
                // IL suffit donc véfirier les coordonné avec la valeurs min et max
                // Attention c'est une grosse approximation mais cela fonction 
                if ((point.X < -L/2.0) || (point.X > L/2.0))
                    pointInter.WithInter = false;
                else if ((point.Y < -H / 2.0) || (point.Y > H / 2.0))
                    pointInter.WithInter = false;
                else if ((point.Z < -W / 2.0) || (point.Z > W / 2.0))
                    pointInter.WithInter = false;
                else
                {
                    pointInter.R = point;
                    pointInter.N = w;
                    pointInter.D = (point - ray.O).Norme();
                    pointInter.WithInter = true;
                    pointInter.ObjectInter = this;
                }
            }
            else
            {
                // Le denominateur est null il n'y a pas d'intesection
                pointInter.WithInter = false;
            }

            return pointInter;
        }

        public bool exist(List<IInterPoint> points,IInterPoint point)
        {
            foreach (IInterPoint pt in points)
                if ((pt.R.X == point.R.X) && (pt.R.Y == point.R.Y) && (pt.R.Z == point.R.Z))
                    return true;
            return false;
        }

        public List<IInterPoint> Collision(IRay ray)
        {
            List<IInterPoint> points = new List<IInterPoint>();

            for (int i =0; i < 6; i++)
            {
                IInterPoint ptInter = CollisionFacette(ray, i);
                if ((ptInter.WithInter) && !exist(points,ptInter))
                {
                    // Cas particilier ou la hitbox et egal a l'objet
                    ptInter.ObjectInter = this;
                    points.Add(ptInter);
                }
            }
            return points;
        }

        public IHitBox GetHitBox()
        {
            return this;
        }

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
            return CloserPoint(Collision(ray));
        }
    }
}