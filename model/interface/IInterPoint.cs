using Math.@interface;
using Model.@interface;

namespace Model.@nterface
{
    public interface IInterPoint 
    {
        // Point résultat de l'intersection
        public ICoord3D R { get; set; }
        // true dans le cas ou il y a une intersection
        public bool WithInter { get; set; }
    }
}