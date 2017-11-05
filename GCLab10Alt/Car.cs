using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10Alt
{
    class Car
    {
        private int count;
        private string make;
        private string model;
        private int year;
        private double price;


        public Car(int count,string make, string model, int year, double price)
        {
            this.count = count;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"{count} {make, - 13} {model, - 8} {year, - 8} {price, 0:C}"; //0:C formats it to the currency.
        }

    }
}
