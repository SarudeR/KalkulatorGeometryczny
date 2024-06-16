using System;

namespace GeometryCalculator
{
    public class Triangle
    {
        // Właściwości przechowujące długości boków trójkąta
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Konstruktor inicjalizujący długości boków
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Metoda obliczająca obwód trójkąta
        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        // Metoda obliczająca pole trójkąta przy użyciu wzoru Herona
        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}