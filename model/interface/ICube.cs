using Math.@interface;

namespace Model.@interface
{
    public interface ICube : IObject3D
    {
        // size du cube
        public double Size { get; set; }
    }
}