using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10Alt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            Console.WriteLine("Welcome to the car dealership! ");

            ArrayList cars = new ArrayList();

            cars.Add(new Car("Nikolai", "Model S", 2017, 54_999.00));
            cars.Add(new Car("Ford", "Escapade", 2014, 31_999.00));
            cars.Add(new Car("Chewiw", "Vette", 2013, 68_549.00));
            cars.Add(new Car("Hyonda", "Prior", 2011, 14_199.00));
            cars.Add(new UsedCar("Nikolai", "Model S", 2017, 54_999.00, "(Used)", 30_400.05));
            cars.Add(new UsedCar("Hello", "Model S", 2017, 54_999.00, "(Used)", 25_000.05));

            while (repeat)
            {
                while (cars.Count > 0)
                {
                    Console.WriteLine("\nHere are our current list of cars!\n");
                    Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
                    Console.WriteLine("  Make         Model    Year        Price      (IfUsed) Miles");
                    Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
                    CarsList(cars);
                    Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
                    Console.Write("\nWhich car would you like to buy? ");

                    if (Console.ReadLine() == "q")
                    {
                        break;
                    }

                    int index = Validator(cars);


                    Console.WriteLine(cars[index]);

                    Console.Write("Would you like to buy this car? (y/n) ");
                    string answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        cars.RemoveAt(index);
                        Console.WriteLine("\nThank you for purchasing this car!");
                        repeat = true;
                    }

                    else if (answer == "n")
                    {
                        repeat = true;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, Please enter a valid input! ");
                    }

                }

                Console.WriteLine("We are all sold out!");
                repeat = false;
            }

            Console.WriteLine("Thank you for shopping!\n Goodbye! ");
        }

        private static int Validator(ArrayList cars)
        {
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= cars.Count)
            {
                Console.Write("Sorry, please enter a valid input: ");
            }
            return index;
        }

        private static void CarsList(ArrayList cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}:{cars[i]}");
            }
        }
    }
}