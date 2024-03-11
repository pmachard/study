using Math.implem;
using Math.@interface;

namespace Model.@interface
{
    public interface ICameraRay
    {
        // repére origine du de la camera du lancer de rayon
        public ICoordSystem CS { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public double DeltaH { get; }
        public double DeltaL { get; }
        public int NbrPointH { get; set; }
        public int NbrPointL { get; set; }

        bool CheckCoord(int x, int y);
        ICoord3D GetCoord(int x, int y);

        IImage InitImage();
    }
}