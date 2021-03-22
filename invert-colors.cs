// This program accepts a png, inverts all the colors, and outputs another png.

using System;
using System.Drawing;

//Bitmap image1;

public class MyClass
{
//    public Bitmap (string filename);
    public static void Main()
    {
        var image1 = new Bitmap("./jungle-arc.png", true);
        
        int x, y;
        
        for (x=0; x<image1.Width; x++)
        {
            for(y=0; y<image1.Height; y++)
            {
                Color pixelColor = image1.GetPixel(x, y);
                var invertedRed = 2147483647 ^ pixelColor.R;
                var invertedGreen = 2147483647 ^ pixelColor.G;
                var invertedBlue = 2147483647 ^ pixelColor.B;
                var invertedColor = Color.FromArgb(invertedBlue, invertedGreen, invertedRed);
                image1.SetPixel(x, y, invertedColor);
            }
        }
        image1.Save("./jungle-arc-inverted.png");
    }
}
