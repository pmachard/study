
using Math.implem;
using Math.@interface;

namespace Model.@interface
{
    public interface ILight
    {
        public IColor Color { get; set; }
        public ICoord3D V { get; set; }
    }
}