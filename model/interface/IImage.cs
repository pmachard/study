using Math.@interface;

namespace Model.@interface
{
    public interface IImage
    {

        public int L { get; set; }
        public int H { get; set; }

        void set(int xImage, int yImage, IColor color);
    }
}