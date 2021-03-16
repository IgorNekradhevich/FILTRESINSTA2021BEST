using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Filtres
    {
        Bitmap bitmap;
        public Filtres(string path)
        {
            bitmap = new Bitmap(path);
        }

        public Bitmap AllGrayLikeMyLife()
        {
            int w = bitmap.Width;
            int h = bitmap.Height;
            Bitmap gray = new Bitmap(w, h);
            for (int i=0; i<w;i++)
            {
                for (int j=0; j<h;j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    gray.SetPixel(i, j, Color.FromArgb(pixel.G, pixel.G, pixel.G));
                }
            }
            return gray;
        }
        public Bitmap GiveMeYourHeart()
        {
            return bitmap; 
        }
    }
}
