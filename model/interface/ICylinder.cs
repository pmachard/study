using Math.@interface;

namespace Model.@interface
{

    public interface ICylinder : IObject3D
    {
        // rayon du cylindre
        public double Radius { get; set; }
        // hauteur du cylindre
        public double Height { get; set; }
    }

}