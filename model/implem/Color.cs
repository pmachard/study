using Model.@interface;

namespace Model.implem
{
    public class Color :  IColor
    {
        public Color(double r, double v, double b)
        {
            R = r;
            V = v;
            B = b;
        }

        public Color(IColor color)
        {
            R = color.R;
            V = color.V;
            B = color.B;
        }

        public double R { get; set; }
        public double V { get; set; }
        public double B { get; set; }
    }
}