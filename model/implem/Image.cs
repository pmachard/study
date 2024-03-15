using Model.@interface;

namespace Model.implem
{
    public class Image:IImage
    {
        private IColor[,] _image;

        public Image(int l, int h)
        {
            L = l;
            H = h;
            _image = new Color[L, H];
        }

        public int L { get; set; }
        public int H { get; set; }

        public void set(int xImage, int yImage, IColor color)
        {
            _image[xImage, yImage] = color;
        }
    }
}