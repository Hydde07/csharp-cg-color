using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ComputaçãoGráfica.Classes
{
	class Metodos
    {
        private static double min(double a, double b, double c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        public static MatrizPixel preenchePixel(Bitmap imagem)
        {
            MatrizPixel retorna = new MatrizPixel(imagem.Width, imagem.Height);
            int width = imagem.Width;
            int height = imagem.Height;
            int pixelSize = 3;

            BitmapData bitmapDataSrc = imagem.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();

                double v1, v2, v3,R,G,B,sum;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Pixel pix = new Pixel();

                        v1 = *(src++);
                        v2 = *(src++);
                        v3 = *(src++);

                        pix.R = (int)v3;
                        pix.G = (int)v2;
                        pix.B = (int)v1;
                        R = (int)v3;
                        G = (int)v2;
                        B = (int)v1;
                        sum = v1 + v2 + v3;

                        pix.C = (int)(255 - v3);
                        pix.M = (int)(255 - v2);
                        pix.Y = (int)(255 - v1);

                        pix.I = (v1 + v2 + v3) / (3.0);

                        if (sum == 0)
                        {
                            
                            v1 = 0;
                            v2 = 0;
                            v3 = 0;
                        }
                        else
                        {
                            v1 = v1 / sum;
                            v2 = v2 / sum;
                            v3 = v3 / sum;
                        }

                        double den = Math.Sqrt(Math.Pow(R - G, 2) + (R - B) * (G - B));
                        if (den != 0)
                        {
                            double alpha = Math.Acos((((R - G) + (R - B)) / 2) / den);
                            pix.H = (v1 <= v2 ? alpha : 2 * Math.PI - alpha);
                        }
                        else
                            pix.H = 0;
                        pix.S = 1 - 3*(min(v1, v2, v3));

                        pix.H = Math.Round(pix.H * 180 / Math.PI, 15);
                        pix.S = Math.Round(pix.S * 100, 15);
                        pix.I = Math.Round(pix.I , 15);

                        retorna.insere(x, y, pix);
                    }
                    src += padding;
                }
            }
            imagem.UnlockBits(bitmapDataSrc);
            return retorna;
        }
        public static void passaLimpo(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        
                        *(dst++) = (byte)b;
                        *(dst++) = (byte)g;
                        *(dst++) = (byte)r;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
    
        public static void luminancia(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        public static void mudaBrilho(Bitmap imgDst, int valor, MatrizPixel mp)
        {
            int width = imgDst.Width;
            int height = imgDst.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imgDst.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();
                Console.WriteLine(valor);
                double r, g, b,h,s,i,v1,v2,v3;
                for(int y = 0;y<height;y++)
                {
                    for(int x = 0;x<width;x++)
                        {
                        Pixel p = mp.retira(x, y);
                        h = p.H * Math.PI / 180;
                        s = p.S/100;
                        i = p.I;
                       
                        i /= 255;

                        v1 = (1 - s) * (1 / 3.0);
                        v1 = (v1 > 1 ? 1 : v1) * (v1 < 0 ? 0 : 1);
                        if (h <= 2 * Math.PI / 3.0)
                        {
                            b = v1;
                            v2 = (1 / 3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI / 3.0 - h));
                            v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);
                            r = v2;
                            g = v3;
                        }
                        else if (2 * Math.PI / 3.0 < h && h <= 4 * Math.PI / 3.0)
                        {
                            h = h - 2 * Math.PI / 3.0;
                            r = v1;
                            v2 = (1 / 3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI / 3.0 - h));
                            v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);

                            g = v2;
                            b = v3;
                        }
                        else
                        {
                            h = h - 4 * Math.PI / 3;
                            g = v1;
                            v2 = (1 / 3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI / 3 - h));
                            v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);

                            b = v2;
                            r = v3;
                        }
                        
                        r = r * 3 * i*valor/100;
                        g = g * 3 * i*valor/100;
                        b = b * 3 * i*valor/100;
                        r = (r > 1 ? 1 : r);
                        g = (g > 1 ? 1 : g);
                        b = (b > 1 ? 1 : b);
                        r = (r < 0 ? 0 : r);
                        g = (g < 0 ? 0 : g);
                        b = (b < 0 ? 0 : b);

                        r *= 255;
                        g *= 255;
                        b *= 255;

                        *(dst++) = (byte)Math.Round(b);
                        *(dst++) = (byte)Math.Round(g);
                        *(dst++) = (byte)Math.Round(r);
                    }
                    dst += padding;
                }
                imgDst.UnlockBits(bitmapDataDst);
            }
        }
        public static void mudaMatiz(Bitmap imgDst, int valor, MatrizPixel mp)
        {
            int width = imgDst.Width;
            int height = imgDst.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imgDst.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                double h, s, i, v1, v2, v3, r, g, b,aux;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        
                        Pixel p = mp.retira(x, y);
                        
                        h = p.H;
                        
                        aux = h + valor;
                        if (aux < 0)
                            aux = 360 + aux;
                        
                        s = Math.Round(p.S/100,15);
                        i = Math.Round(p.I/255,15);
                        

                        h = Math.Abs(aux) % 360;
                        

                        h *= (Math.PI / 180);

                        v1 = (1 - s)*(1/3.0);
                        v1 = (v1 > 1 ? 1 : v1) * (v1<0?0:1);
                        if (h <= 2 * Math.PI / 3.0)
                        {
                            b = v1;
                            v2 = (1/3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI/3.0 - h));
                            v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);
                            r = v2;
                            g = v3;
                        }
                        else if (2 * Math.PI / 3.0 < h && h <= 4 * Math.PI / 3.0)
                        {
                            h = h - 2 * Math.PI / 3.0;
                            r = v1;
                            v2 = (1/3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI / 3.0 - h));
                           v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);

                            g = v2;
                            b = v3;
                        }
                        else
                        {
                            h = h - 4 * Math.PI / 3;
                            g = v1;
                            v2 = (1/3.0) * (1 + (s * Math.Cos(h)) / Math.Cos(Math.PI / 3 - h));
                            v2 = (v2 > 1 ? 1 : v2) * (v2 < 0 ? 0 : 1);
                            v3 = 1 - (v1 + v2);
                            
                            b = v2;
                            r = v3;
                        }
                        r = r * 3 * i;
                        g = g * 3 * i;
                        b = b * 3 * i;                  
                        r = (r > 1 ? 1 : r);
                        g = (g > 1 ? 1 : g);
                        b = (b > 1 ? 1 : b);
                        r = (r < 0 ? 0 : r);
                        g = (g < 0 ? 0 : g);
                        b = (b < 0 ? 0 : b);
                      
                        r *= 255;
                        g *= 255;
                        b *= 255;
                       
                        *(dst++) = (byte)Math.Round(b);
                        *(dst++) = (byte)Math.Round(g);
                        *(dst++) = (byte)Math.Round(r);
                    }
                    dst += padding;
                }
            }
            imgDst.UnlockBits(bitmapDataDst);
        }

        public static void isolaR(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).R;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void isolaG(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).G;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void isolaB(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).B;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void isolaC(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).C;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void isolaM(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).M;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void isolaY(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int isolado = mp.retira(x, y).Y;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        public static void isolaH(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double isolado = mp.retira(x, y).H;
                        isolado /= 360;
                        isolado *= 255;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        public static void isolaS(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double isolado = mp.retira(x, y).S;
                        isolado *= 2.55;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        public static void isolaI(Bitmap imageBitmapDest, MatrizPixel mp)
        {
            int width = imageBitmapDest.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double isolado = mp.retira(x, y).I;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                        *(dst++) = (byte)isolado;
                    }
                    dst += padding;
                }
            }
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
    }
}
