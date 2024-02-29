using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    public class InterPoint : IInterPoint
    {
        public InterPoint()
        {
            R = new Coord3D();
            WithInter = false;
        }

        // Point résultat de l'intersection
        public ICoord3D R { get; set; }
        // true dans le cas ou il y a une intersection
        public bool WithInter { get; set; }
    }
}