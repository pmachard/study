using Math.@interface;
using Math.implem;
using Model.nterface;

namespace Model.implem
{
    public class CameraRay : ICameraRay
    {
        public CameraRay()
        {
            CS = new CoordSystem();
            H = 1.0;
            L = 1.0;
        }

        public ICoordSystem CS { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public int NbrPointH { get; set; }
        public int NbrPointL { get; set; }

        public double DeltaH => H / NbrPointH ;
        public double DeltaL => L / NbrPointL;
    }
}