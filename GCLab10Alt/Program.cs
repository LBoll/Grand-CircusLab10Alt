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
            ArrayList cars = new ArrayList();
            int x = 1;

            cars.Add(new Car(x, "Nikolai", "Model S", 2017, 54_999.00));
            cars.Add(new Car(x, "Ford", "Escapade", 2014, 31_999.00));
            cars.Add(new Car(x, "Chewiw", "Vette", 2013, 68_549.00));
            cars.Add(new Car(x,"Hyonda", "Prior", 2011, 14_199.00));
            cars.Add(new UsedCar(x, "Nikolai", "Model S", 2017, 54_999.00, "Used", 30_400.05));
            cars.Add(new UsedCar(x, "Nikolai", "Model S", 2017, 54_999.00, "Used", 25_000.05));
            cars.Add(new UsedCar(x, "Nikolai", "Model S", 2017, 54_999.00, "Used", 25_000.05));


            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("*=======*======*=======*========*========*========*=======*=======*");
                Console.WriteLine("Make\t\tModel\t Year\tPrice\t    (If Used)\tMiles ");
                Console.WriteLine("*=======*======*=======*========*========*========*=======*=======*");
                foreach (Car c in cars)
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("*=======*======*=======*========*========*========*=======*=======*");


               
                Console.Write("Which car would you like to take? ");
                string input = Console.ReadLine().Trim();
                int numbers = Convert.ToInt32(input);

                Console.WriteLine(cars[numbers - 1]);

                Console.Write("Would you like to buy this car? (y/n) ");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "y")
                {
                    cars.Remove(cars[numbers - 1]);
                    repeat = true;
                }

                else if (answer == "n")
                {
                    repeat = true;
                }

                else
                {
                    Console.WriteLine("Please enter a valid input");
                }

            }
            Console.WriteLine("Thank you for shopping! " );
        }
    }
}