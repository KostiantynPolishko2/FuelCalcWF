using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.Models
{
    public class ImgApp
    {
        public Bitmap bmp { get; set; }
        public Point ptn { get; set; }

        public ImgApp(Image img, Point ptn)
        {
            bmp = new Bitmap(img, new Size(40, 40));
            bmp.MakeTransparent(bmp.GetPixel(3,3));
            this.ptn = ptn;
        }
    }
}
