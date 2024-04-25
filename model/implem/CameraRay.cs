using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class CameraRay : ICameraRay
    {
        public CameraRay()
        {
            Pos = new Coord3D();
            H = 1.0;
            L = 1.0;
        }

        public ICoord3D Pos { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public int NbrPointH { get; set; }
        public int NbrPointL { get; set; }

        public double DeltaH => H / NbrPointH ;
        public double DeltaL => L / NbrPointL;

        public bool CheckCoord(int x, int y)
        {
            if ((x < -NbrPointL / 2) || (x > NbrPointL / 2))
                return false;

            if ((y < -NbrPointH / 2) || (y > NbrPointH / 2))
                return false;

            return true;
        }

        public ICoord3D GetCoord(int x, int y)
        {
            if (!CheckCoord(x, y))
                throw new ArgumentException();

            return new Coord3D(Pos.X + DeltaL * (double)x, Pos.Y + DeltaH * (double)y, Pos.Z);
        }

        public IImage InitImage()
        {
            IImage imageResult = new Image((int)(L / DeltaL), (int)(H / DeltaH));
            imageResult.set(new Color(1.0, 0.0, 0.0));
            return imageResult;
        }
    }
}
