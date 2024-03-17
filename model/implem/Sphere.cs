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
            List<IInterPoint> pointsInter = new List<IInterPoint>();


            // Equation de la phere
            // (x-CS.O.X)^2 + (y-CS.O.y)^2 + (z-CS.O.z)^2 = Radius^2

            // Equation de la droite du rayon
            // x = ray.O.x + ray.V.x * t
            // y = ray.O.y + ray.V.y * t
            // z = ray.O.z + ray.V.z * t

            // (ray.O.x + ray.V.x * t-CS.O.x)^2 + (ray.O.y + ray.V.y * t-CS.O.y)^2 + (ray.O.z + ray.V.z * t-CS.O.z)^2 = Radius^2
            // (ray.V.x * t + ray.O.x - CS.O.x)^2 + (ray.V.y * t + ray.O.y - CS.O.y)^2 + (ray.V.z * t + ray.O.z - CS.O.z)^2 = Radius^2

            // ray.V.x^2 * t^2 + 2*t*(ray.V.x + ray.O.x - CS.O.x) + (ray.O.x - CS.O.x)^2 +
            //      ray.V.y^2 * t^2 + 2*t*(ray.V.y + ray.O.y - CS.O.y) + (ray.O.y - CS.O.y)^2 +
            //      ray.V.z^2 * t^2 + 2*t*(ray.V.z + ray.O.z - CS.O.z) + (ray.O.z - CS.O.z)^2 = Radius^2

            // t^2*(ray.V.x^2 + ray.V.y^2 + ray.V.z^2) + 2*t*(ray.V.x + ray.O.x - CS.O.x + ray.V.y + ray.O.y - CS.O.y + ray.V.z + ray.O.z - CS.O.z) +
            //      (ray.O.x - CS.O.x)^2 + (ray.O.y - CS.O.y)^2 + (ray.O.z - CS.O.z)^2 = Radius^2

            // Equation au format a*t^2 + b*t + c = 0

            // a = ray.V.x^2 + ray.V.y^2 + ray.V.z^2
            // b = 2*(ray.V.x + ray.O.x - CS.O.x + ray.V.y + ray.O.y - CS.O.y + ray.V.z + ray.O.z - CS.O.z)
            // c = (ray.O.x - CS.O.x)^2 + (ray.O.y - CS.O.y)^2 + (ray.O.z - CS.O.z)^2 - Radius^2

            double a = ray.V.X * ray.V.X + ray.V.Y * ray.V.Y + ray.V.Z * ray.V.Z;
            double b = 2.0 * (ray.V.X + ray.O.X - CS.O.X + ray.V.Y + ray.O.Y - CS.O.Y + ray.V.Z + ray.O.Z - CS.O.Z);
            double c = (ray.O.X - CS.O.X)* (ray.O.X - CS.O.X) + (ray.O.Y - CS.O.Y) * (ray.O.Y - CS.O.Y) + (ray.O.Z - CS.O.Z) * (ray.O.Z - CS.O.Z) - Radius * Radius;

            double delta = b - 4.0 * a * c;

            if (delta > 0.0)
            {
                // Il y a deux sulotions à l'équation
                double t0 = (-b - System.Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a);
                ICoord3D p = ray.O + (ray.V * t0);
                IInterPoint pointInter = new InterPoint();
                pointsInter.Add(pointInter);

                double t1 = (-b + System.Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a);
                p = ray.O + (ray.V * t1);
                pointInter = new InterPoint();
                pointsInter.Add(pointInter);
            }
            else if (delta == 0.0)
            {
                // Il y a une sulotion à l'équation
                double t = -b / (2.0 * a);
                ICoord3D p = ray.O + (ray.V * t);
                IInterPoint pointInter = new InterPoint();
                pointsInter.Add(pointInter);
            }
            else
            {
                // Il n 'y a pas de solution à l'équation
            }

            IInterPoint result = CloserPoint(pointsInter);
            return result;
        }

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