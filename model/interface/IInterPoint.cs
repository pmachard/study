using Math.@interface;
using Model.@interface;

namespace Model.@interface
{
    public interface IInterPoint 
    {
        // Point résultat de l'intersection
        public ICoord3D R { get; set; }
        // Vecteur Normal résultat de l'intersection
        public ICoord3D N { get; set; }
        // Distance entre le point central et l'intersection
        public double D { get; set; }
        // True dans le cas ou il y a une intersection
        public bool WithInter { get; set; }
        // Objet d'intersection
        public IObject3D ObjectInter { get; set; }
        // Coulor calculé sur l'intersection
        public IColor ColorInter { get; set; }
    }
}