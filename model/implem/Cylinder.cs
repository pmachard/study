using Math.@interface;
using Math.implem;
using Model.@interface;
using System.Drawing;
using Model.nterface;
using Model.implem;
using System;

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
            Mat = new Material();
        }
        public Cylinder(ICoordSystem localCoordSystem, string name, double radius, double height)
        {
            CS = localCoordSystem;
            Radius = radius;
            Height = height;
            Name = name;
            Mat = new Material();
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public ICoordSystem CS { get; set; }
        public string Name { get; set; }
        public IMaterial Mat { get ; set ; }

        public IInterPoint Compute(IRay ray)
        {
            throw new NotImplementedException();
        }

        public IHitBox GetHitBox()
        {
            return new HitBox(CS, Radius, Radius, Height);
        }

        public void RunTranlation(ICoord3D v)
        {
            throw new NotImplementedException();
        }
    }
}
