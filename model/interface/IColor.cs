using Math.@interface;

namespace Model.@interface
{
    public interface IColor
    {
        public double R { get; set; }
        public double V { get; set; }
        public double B { get; set; }

        public byte r { get; }
        public byte v { get; }
        public byte b { get; }

    }
}