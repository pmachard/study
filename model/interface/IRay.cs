using Math.@interface;
using Model.@interface;

namespace Model.@interface
{
    // Rayon utilisé dans l'algo du raytracing
    public interface IRay
    {
        // origine du rayon
        public ICoord3D O { get; set; }
        // vecteur directeur du rayon
        public ICoord3D V { get; set; }

    }
}