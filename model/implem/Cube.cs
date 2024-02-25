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
            Size = 1.0;
            Name = name;
        }

        public Cube(ICoordSystem coordSystem, string name,double size)
        {
            CS = coordSystem;
            Size = size;
            Name = name;
        }

        public ICoordSystem CS { get; set; }
        public double Size { get; set; }
        public string Name { get; set; }


        public void RunTranlation(ICoord3D v)
        {
            CS.O = CS.O + v;
        }
    }
}