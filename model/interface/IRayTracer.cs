using Math.@interface;
using Model.implem;
using Model.@interface;

namespace Model.@interface
{
    // modelisation du trace de rayon
    public interface IRayTracer 
    {
        // repére origine du lancer de rayon
        public ICoordSystem CS { get; set; }

        public ICameraRay Camera{ get; set; }

        IRay ComputeRay(int x, int y);

        IImage Compute(IScene scene);
    }
}