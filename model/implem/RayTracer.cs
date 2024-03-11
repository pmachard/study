using Math.@interface;
using Math.implem;
using Model.@interface;
using System.Drawing;
using Model.nterface;

namespace Model.implem
{
    // modelisation du trace de rayon
    public class RayTracer : IRayTracer
    {
        public RayTracer()
        {
            CS = new CoordSystem();
            Camera = new CameraRay();
        }

        public ICoordSystem CS { get; set; }
        public ICameraRay Camera { get; set; }

        public IRay ComputeRay(int x, int y)
        {
            if (!Camera.CheckCoord(x, y))
                throw new ArgumentException();

            ICoord3D coord = Camera.GetCoord(x, y);
            ICoord3D vect = coord - CS.O;

            return new Ray(CS.O, vect);
        }

        public IImage Compute(IScene scene)
        {
            if (Camera == null)
                return null;

            if (CS == null)
                return null;

            IImage image = Camera.InitImage();

            for (int x = (int)(-Camera.L / Camera.DeltaL / 2), xImage = 0; x < (int)(Camera.L / Camera.DeltaL / 2); x++, xImage++)
            {
                for (int y = (int)(-Camera.H / Camera.DeltaH / 2), yImage = 0; y < (int)(Camera.H / Camera.DeltaH / 2); y++, yImage++)
                {
                    IRay ray = ComputeRay(x, y);
                    IColor color = Compute(scene, ray);

                    image.set(xImage, yImage, color);
                }
            }
            return image;
        }

        public IColor Compute(IScene scene,IRay ray)
        {

            if (scene == null)
                return null;

            if (ray == null)
                return null;

            foreach(IObject3D object3D in scene)
            {
                // Recupére la hitbox pour faire un premier test de collision avec l'objet
                IHitBox hitBox = object3D.GetHitBox();
                if (hitBox == null) 
                    continue;

                List<IInterPoint> pointsInter = hitBox.Collision(ray);
                if (pointsInter.Count > 0)
                {
                    // Il y a potentiellement un objet en collision avec le rayon
                    // Calcul le point de collision exacte avec la distance et la normal (normal pour un gain de temps par la suite) 

                    IPointCollision pt = object3D.Compute(ray);
                }
            }
            // Recherche le point le plus proche dans la liste des collisions
            return null;
        }
    }
 }