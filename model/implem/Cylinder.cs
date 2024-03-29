using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class Cylinder : ICylinder
    {
        public Cylinder(string name = "")
        {
            CS = new CoordSystem();
            Radius = 1.0;
            Height = 1.0;
            Name = name;
        }
        public Cylinder(ICoordSystem localCoordSystem, string name, double radius, double height)
        {
            CS = localCoordSystem;
            Radius = radius;
            Height = height;
            Name = name;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public ICoordSystem CS { get; set; }
        public string Name { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            throw new NotImplementedException();
        }
    }
}