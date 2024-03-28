using Model.@interface;

using SkiaSharp;

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

        public void save(string fileName)
        {
            // Créer une nouvelle bitmap avec les dimensions spécifiées
            using (var surface = SKSurface.Create(new SKImageInfo(L, H)))
            {
                // Dessiner quelque chose sur la bitmap (optionnel)
                SKCanvas canvas = surface.Canvas;

                for (int y = 0; y < H; y++)
                {
                    for (int x = 0; x < L; x++)
                    {
                        IColor currentColor = _image[x, y];
                        byte r = (byte)(currentColor.R * 255.0);
                        byte v = (byte)(currentColor.V * 255.0);
                        byte b = (byte)(currentColor.B * 255.0);
                        canvas.DrawPoint(x, y, new SKColor(r,v,b));
                    }
                }

                // Enregistrer la bitmap dans un fichier (optionnel)
                using (var image = surface.Snapshot())
                using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
                using (var stream = System.IO.File.OpenWrite(fileName))
                {
                    data.SaveTo(stream);
                }
            }


        }

        public void set(int xImage, int yImage, IColor color)
        {
            _image[xImage, yImage] = color;
        }

        public void set(IColor color)
        {
            for (int x = 0; x < L; x++)
                for (int y = 0; y < H; y++)
                    set(x, y, color);
        }
    }
}