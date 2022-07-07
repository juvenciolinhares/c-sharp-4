using MetodosAbstratosExercicio.Entities.Enum;
using MetodosAbstratosExercicio.Entities;
using System.Globalization;
using System;
using System.Collections.Generic;

namespace MetodosAbstratosExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crio minha lista pra armazenar os shapes
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("r/c: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color(Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.WriteLine("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));

                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
