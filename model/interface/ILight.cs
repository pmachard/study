
using Math.implem;
using Math.@interface;

namespace Model.@interface
{
    public interface ILight
    {
        // repére origine de la lumiere
        public ICoordSystem CS { get; set; }

        public IColor Color { get; set; }
        public ICoord3D V { get; set; }
    }
}