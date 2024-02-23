using Math.@interface;
using Model.@interface;

namespace Model.@nterface
{
    public interface IEdge : ITranslatable
    {

        // Point A du bord
        public ICoord3D A { get; set; }
        // Point B du bord
        public ICoord3D B { get; set; }
    }
}