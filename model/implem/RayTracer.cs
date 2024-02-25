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

    }
}