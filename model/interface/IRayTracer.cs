using Math.@interface;
using Model.implem;
using Model.@interface;

namespace Model.@interface
{
    // modelisation du trace de rayon
    public interface IRayTracer 
    {
        // Origine du lancer de rayon
        public ICoordSystem CS { get; set; }
        // Camera utilisé pour le lancer de rayon
        public ICameraRay Camera { get; set; }

        public ILight Light { get; set; }

        // Calcul le rayon qui passe par un pixel particulier de la camera
        IRay ComputeRay(int x, int y);
        // Cacule une image de la scene avec les parametres du lancer de rayon
        IImage Compute(IScene scene);
    }
}