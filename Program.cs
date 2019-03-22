using Kalimage;
using System;
using System.Drawing;

namespace Kalimage
{
    class Program
    {
        static void Main(string[] args)
        {
            //test median filter
            Bitmap originalImage = new Bitmap(args[0]);
            ImageFiltering filter = new ImageFiltering(originalImage);
            filter.MedianFilter(Convert.ToInt16(args[1])).Save(args[2]);
        }
    }
}
