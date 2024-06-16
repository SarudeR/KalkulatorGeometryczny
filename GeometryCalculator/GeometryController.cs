using System;
using System.Drawing;

namespace GeometryCalculator
{
    public class GeometryController
    {
        // Metoda uruchamiająca główną pętlę programu
        public void Run()
        {
            while (true)
            {
                // Wyświetlanie menu wyboru figury geometrycznej
                Console.WriteLine("Wybierz figurę:");
                Console.WriteLine("1. Koło");
                Console.WriteLine("2. Prostokąt");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Wyjście");

                var choice = Console.ReadLine();

                // Obsługa wyboru użytkownika
                switch (choice)
                {
                    case "1":
                        HandleCircle();
                        break;
                    case "2":
                        HandleRectangle();
                        break;
                    case "3":
                        HandleTriangle();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        // Metoda obsługująca obliczenia dla koła
        private void HandleCircle()
        {
            Console.WriteLine("Podaj promień koła:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Obwód koła: {circle.CalculatePerimeter()}");
            Console.WriteLine($"Pole koła: {circle.CalculateArea()}");
        }

        // Metoda obsługująca obliczenia dla prostokąta
        private void HandleRectangle()
        {
            Console.WriteLine("Podaj długość prostokąta:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostokąta:");
            double width = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine($"Obwód prostokąta: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Pole prostokąta: {rectangle.CalculateArea()}");
        }

        // Metoda obsługująca obliczenia dla trójkąta
        private void HandleTriangle()
        {
            Console.WriteLine("Podaj długość pierwszego boku trójkąta:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku trójkąta:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość trzeciego boku trójkąta:");
            double sideC = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine($"Obwód trójkąta: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Pole trójkąta: {triangle.CalculateArea()}");
        }
    }
}