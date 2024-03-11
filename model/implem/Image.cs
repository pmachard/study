using Model.@interface;

namespace Model.implem
{
    public class Image:IImage
    {
        public Image(int l, int h)
        {
            L = l;
            H = h;
        }

        public int L { get; set; }
        public int H { get; set; }

        public void set(int xImage, int yImage, IColor color)
        {
        }
    }
}