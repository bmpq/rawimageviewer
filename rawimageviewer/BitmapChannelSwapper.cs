using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace rawimageviewer
{
    public static class BitmapChannelSwapper
    {
        public enum ColorSwapType
        {
            None,
            ShiftRight,
            ShiftLeft,
            SwapBlueAndRed,
            SwapBlueAndGreen,
            SwapRedAndGreen
        }

        public static Bitmap SwapColors(Bitmap bmp, ColorSwapType type)
        {
            if (type == ColorSwapType.None)
                return bmp;

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i += 4)
            {
                switch (type)
                {
                    case ColorSwapType.ShiftRight:
                        byte red = rgbValues[i + 2];
                        byte blue = rgbValues[i];
                        byte green = rgbValues[i + 1];
                        rgbValues[i] = red;
                        rgbValues[i + 1] = blue;
                        rgbValues[i + 2] = green;
                        break;
                    case ColorSwapType.ShiftLeft:
                        red = rgbValues[i];
                        blue = rgbValues[i + 2];
                        green = rgbValues[i + 1];
                        rgbValues[i] = green;
                        rgbValues[i + 1] = red;
                        rgbValues[i + 2] = blue;
                        break;
                    case ColorSwapType.SwapBlueAndRed:
                        red = rgbValues[i];
                        blue = rgbValues[i + 2];
                        rgbValues[i] = blue;
                        rgbValues[i + 2] = red;
                        break;
                    case ColorSwapType.SwapBlueAndGreen:
                        blue = rgbValues[i];
                        green = rgbValues[i + 1];
                        rgbValues[i] = green;
                        rgbValues[i + 1] = blue;
                        break;
                    case ColorSwapType.SwapRedAndGreen:
                        red = rgbValues[i + 2];
                        green = rgbValues[i + 1];
                        rgbValues[i + 1] = red;
                        rgbValues[i + 2] = green;
                        break;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
    }
}
