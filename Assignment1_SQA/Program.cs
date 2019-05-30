using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_SQA
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, choice;
            Rectangle r = new Rectangle();
            String input = string.Empty;
            do
            {
                Console.Write("Enter the Length of Rectangle: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out length) || (length <= 0));

            do
            {
                Console.Write("Enter Width: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out width) || (width <= 0));

            Rectangle rectangle = new Rectangle(length, width);

            while (true)
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("1.Get Rectangle Length");
                    Console.WriteLine("2.Change Rectangle Length");
                    Console.WriteLine("3.Get Rectangle Width");
                    Console.WriteLine("4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle Perimeter");
                    Console.WriteLine("6.GetRectangle Area");
                    Console.WriteLine("7.Exit");
                    Console.WriteLine("\n");
                    Console.WriteLine("Please enter your option");
                    input = Console.ReadLine();

                }

                while (!int.TryParse(input, out choice) || (choice <= 0 && choice >= 8));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Current Length=" + rectangle.GetLength());
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Enter Length of Rectangle: ");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out length) || (length <= 0));
                        Console.WriteLine("New Length=" + rectangle.SetLength(length));
                        break;
                    case 3:
                        Console.WriteLine("Current Width=" + rectangle.GetWidth());
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Enter Width of Rectangle: ");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out width) || (width <= 0));
                        Console.WriteLine("New Width=" + rectangle.SetWidth(width));
                        break;
                    case 5:
                        Console.WriteLine("Perimeter=" + rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area=" + rectangle.GetArea());
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }

            }
        }
    }
}
