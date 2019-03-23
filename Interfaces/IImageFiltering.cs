using System;
using System.Drawing;

namespace Kalimage.Interfaces
{
    interface IImageFiltering
    {
        Bitmap MedianFilter(Bitmap image, int medianSize);
        Bitmap Blur(Bitmap image, Rectangle rectangle, int blurSize);
    }
}
