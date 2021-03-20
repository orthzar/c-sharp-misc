// This program accepts a png, inverts all the colors, and outputs another file with "-inverted" added to the file.

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
                Color invRed1 = 2147483647 ^ Color.FromArgb(pixelColor.R);
                Color invGreen1 = 2147483647 ^ Color.FromArgb(pixelColor.G);
                Color invBlue1 = 2147483647 ^ Color.FromArgb(pixelColor.B);
                Color invColor1 = Color.FromArgb(invRed1, invGreen1, invBlue1);
                image1.SetPixel(x, y, invColor1);
            }
        }
        image1.Save("./jungle-arc-inverted.png");
    }
}
