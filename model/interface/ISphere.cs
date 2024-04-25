using Math.@interface;
using Model.@interface;

namespace Model.@interface
{
    public interface ISphere : IObject3D
    {
        public double Radius { get; set; }
    }
}
