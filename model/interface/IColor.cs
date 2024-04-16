using Math.@interface;

namespace Model.@interface
{
    public interface IColor
    {
        public double R { get; set; }
        public double V { get; set; }
        public double B { get; set; }

        // Operateur de multiplication avec une couleur 
        static public ICoord3D operator *(ICoord3D a, double coef) { return a.operator_mult(coef); }
        public IColor operator_mult(double coef);
    }
}