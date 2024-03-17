using Math.@interface;
using Model.@interface;

namespace Model.@interface
{
    public interface IInterPoint 
    {
        // Point r�sultat de l'intersection
        public ICoord3D R { get; set; }
        // Vecteur Normal r�sultat de l'intersection
        public ICoord3D N { get; set; }
        // Distance entre le point central et l'intersection
        public double D { get; set; }
        // True dans le cas ou il y a une intersection
        public bool WithInter { get; set; }
        // Objet d'intersection
        public IObject3D ObjectInter { get; set; }
        // Coulor calcul� sur l'intersection
        public IColor ColorInter { get; set; }
    }
}