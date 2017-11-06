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

            Console.WriteLine("Welcome to the Boll dealership! ");

            ArrayList cars = new ArrayList();

            cars.Add(new Car("Genesis", "G80", 2017, 78_599.00));
            cars.Add(new Car("Dacia", "Duster", 2017, 31_999.00));
            cars.Add(new Car("Audi", "A3", 2017, 68_549.00));
            cars.Add(new Car("Fiat", "500C", 2017, 14_199.00));
            cars.Add(new UsedCar("DKW", "F8", 1939, 9_500.00, "(Used)", 1_600.99));
            cars.Add(new UsedCar("BYD", "Flyer", 2004, 1800.01, "(Used)", 25_000.05));
            cars.Add(new UsedCar("Lexus", "IS", 2014, 7_899.90, "(Used)", 110_980.25));

            while (repeat)
            {
                Garage(cars);

                int index = Validator(cars);// Method for validation

                if (index == 100)
                {
                    break;
                }

                Console.WriteLine(cars[index]);//Displays what car you would like to purchase

                Console.Write("Would you like to buy this car? (y/n) ");
                repeat = BuyCar(repeat, cars, index);//Removes the car if you want to buy it, otherwise continues to trying and buy a car.

            }

            
            Console.WriteLine("Thank you for shopping!\nGoodbye! ");
        }




        private static void Garage(ArrayList cars)
        {
            Console.WriteLine("\nHere are our current list of cars!");
            Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
            Console.WriteLine("  Make         Model    Year        Price     (IfUsed) Miles");
            Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}:{cars[i]}");
            }
            Console.WriteLine("*======*======*======*======*======*======*======*======*======* ");
            Console.Write("\nWhich car would you like to buy? ");
        }




        private static bool BuyCar(bool repeat, ArrayList cars, int index)
        {
            Car choice = (Car)cars[index];
            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == "y")
            {
                cart.Add(index);
                cars.RemoveAt(index);//Removes whatever car the user decided to buy
                Console.WriteLine($"\nThank you for purchasing! You are going to love your new {choice.Make} {choice.Model}!");
                repeat = true;
            }

            else if (answer == "n")
            {
                Console.WriteLine($"\n${choice.Price} a little steep for ya? Well see if there is any more you like! ");
                repeat = true;
            }

            else
            {
                Console.WriteLine("Sorry, Please enter a valid input! (enter Q to leave the dealership): ");
            }

            return repeat;
        }




        private static int Validator(ArrayList cars)
        {
            string input = Console.ReadLine();
            int index;

            if (input == "q")
            {
                return 100;
            }

            while (!int.TryParse(input, out index) || index < 0 || index >= cars.Count)
            {
                Console.Write("Please pick a number for one of the cars listed above: ");
            }

            return index;
        }
    }
}