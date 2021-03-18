// This program inverts the colors for a given png.

using System;
using System.Drawing;

public class MyClass
{
    public static Image image1;
    public static void Main()
    {
        image1 = new Bitmap("./jungle-arc.png", true); // Change to be whatever image you have
        
        int x, y;
        
        for (x=0; x<image1.Width; x++)
        {
            for(y=0; y<image1.Height; y++)
            {
                Color pixelColor = image1.GetPixel(x, y);
                Color invRed = 2147483647 ^ Color.FromArgb(pixelColor.R);
                Color invGreen = 2147483647 ^ Color.FromArgb(pixelColor.G); // xor'ing with an int32 of all 1's seems appropriate
                Color invBlue = 2147483647 ^ Color.FromArgb(pixelColor.B);
                Color invColor = Color.FromArgb(invRed, invGreen, invBlue);
                image1.SetPixel(x, y, invColor);
            }
        }
    }
    image1.Save("./jungle-arc-inverted.png");
}
