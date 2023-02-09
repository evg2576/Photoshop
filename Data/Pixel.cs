using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        double r;
        public double R
        {
            get { return r; }
            set
            {
                r = Check(value);
            }
        }

        double g;
        public double G
        {
            get { return g; }
            set
            {
                g = Check(value);
            }
        }

        double b;
        public double B
        {
            get { return b; }
            set
            {
                b = Check(value);
            }
        }

        public Pixel(double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            R = r;
            G = g;
            B = b;
        }

        double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }

        public static Pixel operator*(Pixel pixel, double number)
        {
            return new Pixel(
                        Trim(pixel.R * number),
                        Trim(pixel.G * number),
                        Trim(pixel.B * number));
        }
    }
}
