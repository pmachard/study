
using Math.implem;
using Math.@interface;

namespace Model.@interface
{
    public interface IMaterial
    {
        public IColor C { get; set; }
        public double Reflect { get; set; }
    }
}