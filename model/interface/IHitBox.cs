using Math.@interface;
using Model.nterface;

namespace Model.@interface
{
    public interface IHitBox : IObject3D
    {
        // size du cube
        public double L { get; set; }
        public double W { get; set; }
        public double H { get; set; }

        // retourne les 8 points definissant la hitbox
        List<ICoord3D> GetPtsLocal();
        List<ICoord3D> GetPtsAbsolute();
        List<ICoord3D> Collision(IRay ray);
    }
}