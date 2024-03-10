using Math.@interface;
using Model.@interface;

namespace Model.@nterface
{
    // modelisation du trace de rayon
    public interface IRayTracer 
    {
        // repére origine du lancer de rayon
        public ICoordSystem CS { get; set; }

        public ICameraRay Camera{ get; set; }

        IRay ComputeRay(int v1, int v2);
    }
}