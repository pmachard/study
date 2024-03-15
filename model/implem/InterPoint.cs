using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class InterPoint : IInterPoint
    {
        public InterPoint()
        {
            R = new Coord3D();
            N = new Coord3D(1.0,0.0,0.0);
            D = 0.0;
            WithInter = false;
            ColorInter = new Color(0.0, 0.0, 0.0);
        }

        // Point résultat de l'intersection
        public ICoord3D R { get; set; }
        // true dans le cas ou il y a une intersection
        public bool WithInter { get; set; }
        // Vecteur normal au point d'intersection avec l'objet
        public ICoord3D N { get ; set ; }
        // Distance entre le point origine du rayon et l'intesection
        public double D { get ; set ; }
        // Objet intersection 
        public IObject3D ObjectInter { get; set; }
        // Coulor calculé sur l'intersection
        public IColor ColorInter { get; set; }

    }
}