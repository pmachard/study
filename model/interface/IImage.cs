using Math.@interface;

namespace Model.@interface
{
    public interface IImage
    {

        public int L { get; set; }
        public int H { get; set; }

        void save(string v);
        void set(int xImage, int yImage, IColor color);
        void set(IColor color);
    }
}