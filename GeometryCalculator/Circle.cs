using System;

namespace GeometryCalculator
{
    public class Circle
    {
        // Właściwość przechowująca promień koła
        public double Radius { get; set; }

        // Konstruktor inicjalizujący promień
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Metoda obliczająca obwód koła
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        // Metoda obliczająca pole koła
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}