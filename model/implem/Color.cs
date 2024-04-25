using Model.@interface;

namespace Model.implem
{
    public class Color : IColor
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


        public byte r
        {
            get
            {
                return (byte)(R * 255.0);
            }
        }
        public byte v
        {
            get
            {
                return (byte)(V * 255.0);
            }
        }

        public byte b
        {
            get
            {
                return (byte)(B * 255.0);
            }   
        }

    }
}