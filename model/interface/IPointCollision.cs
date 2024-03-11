using Math.@interface;

namespace Model.@interface
{
    public interface IPointCollision
    {
        public ICoord3D Point { get; set; }
        public ICoord3D Normal { get; set; }
        public double Distance { get; set; }
    }
}
