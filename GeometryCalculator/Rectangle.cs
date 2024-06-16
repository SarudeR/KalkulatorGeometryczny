using System;

namespace GeometryCalculator
{
    public class Rectangle
    {
        // Właściwości przechowujące długość i szerokość prostokąta
        public double Length { get; set; }
        public double Width { get; set; }

        // Konstruktor inicjalizujący długość i szerokość
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Metoda obliczająca obwód prostokąta
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        // Metoda obliczająca pole prostokąta
        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}