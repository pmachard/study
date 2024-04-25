using Math.@interface;
using Math.implem;
using Model.@interface;
using System.Drawing;
using Model.nterface;
using System.Collections.Generic;

namespace Model.implem
{
    // modelisation du trace de rayon
    public class RayTracer : IRayTracer
    {
        public RayTracer()
        {
            Pos = new Coord3D();
            Camera = new CameraRay();
            Light = new Light();
        }

        public ICoord3D Pos { get; set; }
        public ICameraRay Camera { get; set; }
        public ILight Light { get; set; }

        public IRay ComputeRay(int x, int y)
        {
            if (!Camera.CheckCoord(x, y))
                throw new ArgumentException();

            ICoord3D vect = Camera.GetCoord(x, y) - Pos;           

            return new Ray(Pos, vect);     
        }

        public IImage Compute(IScene scene)
        {
            // 
            IImage image = Camera.InitImage();

            //
            for (   int x = (int)(-Camera.L / Camera.DeltaL / 2), xImage = 0; 
                    x < (int)(Camera.L / Camera.DeltaL / 2); 
                    x++, xImage++)
            {
                for (   int y = (int)(-Camera.H / Camera.DeltaH / 2), yImage = 0; 
                        y < (int)(Camera.H / Camera.DeltaH / 2); 
                        y++, yImage++)
                {
                    IRay ray = ComputeRay(x, y);
                    IColor color = Compute(scene, ray);

                    image.set(xImage, yImage, color);
                }
            }
            return image;
        }

        public IInterPoint CloserPoint(List<IInterPoint> points)
        {
            if (points == null)
                return null;
            if (points.Count() == 0)
                return null;

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


        public List<IInterPoint> ComputeInter(IScene scene, IRay ray)
        {
            List<IInterPoint> allPointsInter = new List<IInterPoint>();

            foreach (IObject3D object3D in scene)
            {
                if (object3D == null)
                    continue;

                // Recup�re la hitbox pour faire un premier test de collision avec l'objet
                IHitBox hitBox = object3D.GetHitBox();
                if (hitBox == null)
                    continue;

                List<IInterPoint> pointsInter = hitBox.Collision(ray);
                if (pointsInter.Count() == 0)
                    continue;

                // Il y a potentiellement un objet en collision avec le rayon
                // Calcul le point de collision exacte avec la distance et la normal (normal pour un gain de temps par la suite) 
                IInterPoint pointInterReal = object3D.Compute(ray);
                if (pointInterReal.WithInter == true)
                    allPointsInter.Add(pointInterReal);
            }
            return allPointsInter;
        }

        public IColor Compute(IScene scene,IRay ray)
        {
            IColor colorResult = new Color(1.0,0.0,0.0);

            List<IInterPoint> allPointsInter = ComputeInter(scene, ray);

            if (allPointsInter.Count()>0)
            {
                // recupére le point d'intersection le plus proche 
                IInterPoint closerPoint = CloserPoint(allPointsInter);

                IObject3D obj = closerPoint.ObjectInter;
                IMaterial mat = obj.Mat;
                IColor col = mat.C;
                ICoord3D n = closerPoint.N;
                ICoord3D l = Light.V;

                double scal = l ^ n;

                if (scal>0.0)
                {
                    closerPoint.ColorInter = new Color(col.R * scal, col.V * scal, col.B * scal);
                    colorResult = closerPoint.ColorInter;
                }
                else
                {
                    closerPoint.ColorInter = new Color(0.0,0.0,0.0);
                    colorResult = closerPoint.ColorInter;
                }
            }
            // Recherche le point le plus proche dans la liste des collisions
            return colorResult;
        }
    }
}