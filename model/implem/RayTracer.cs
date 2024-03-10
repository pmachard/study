using Math.@interface;
using Math.implem;
using Model.@interface;
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
    }
}