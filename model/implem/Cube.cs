using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class Cube : ICube
    {
        public Cube(string name="")
        {
            CS = new CoordSystem();
            Name = name;
            Size = 1.0;
        }

        public Cube(ICoordSystem coordSystem, string name,double size)
        {
            CS = coordSystem;
            Name = name;
            Size = size;
        }

        public ICoordSystem CS { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        public IHitBox GetHitBox()
        {
            return new HitBox(CS, Size, Size, Size);
        }

        public void RunTranlation(ICoord3D v)
        {
            CS.O = CS.O + v;
        }
    }
}