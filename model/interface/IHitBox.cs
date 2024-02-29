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
        public List<ICoord3D> GetPtsLocal();

        public List<ICoord3D> GetPtsAbsolute();

        public List<IInterPoint> Collision(IRay ray);

        public List<ICoord3D> GetFacette(int NumFacette);
    }
}