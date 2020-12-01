using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Geometry
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в программу, генерирующую правильные треугольники, прямоугольники, " +
                              "пятиугольники и шестиугольники!");
            List<Shape> figures = new List<Shape>();
            Console.WriteLine("Введите желаемое количество фигур");
            Console.Write("Треугольников: ");
            int TriangleQuantity = QuantityEnter();
            FigureCreate(TriangleQuantity, figures, 3);
            Console.Write("Прямоугольников: ");
            int RectangleQuantity = QuantityEnter();
            FigureCreate(RectangleQuantity, figures, 4);
            Console.Write("Пятиугольников: ");
            int PentagonQuantity = QuantityEnter();
            FigureCreate(PentagonQuantity, figures, 5);
            Console.Write("Шестиугольников: ");
            int HexagonQuantity = QuantityEnter();
            FigureCreate(HexagonQuantity, figures, 6);
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter("Output.txt"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    foreach (Shape figure in figures)
                    {
                        serializer.Serialize(writer, figure);
                        sw.WriteLine();
                    }
                }
            }
            Console.WriteLine($"Файл записан. Путь к файлу:");
            Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "Output.txt"));
            Console.ReadLine();
        }

        static int QuantityEnter()
        {
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.Write("Попробуйте ввести число: ");
            }

            return quantity;
        }

        static void FigureCreate(int quantity, List<Shape> figures, int figureType)
        {
            switch (figureType)
            {
                case 3:
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            figures.Add(new Triangle());
                        }

                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            figures.Add(new Rectangle());
                        }

                        break;
                    }
                case 5:
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            figures.Add(new Pentagon());
                        }

                        break;
                    }
                case 6:
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            figures.Add(new Hexagon());
                        }

                        break;
                    }
            }
        }
    }
}