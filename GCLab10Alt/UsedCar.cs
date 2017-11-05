using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10Alt
{
    class UsedCar : Car
    {
        private string used;
        private double miles;

        public string Used
        {
            get { return used; }
            set { used = value; }
        }

        public double Miles
        {
            get { return miles; }
            set { miles = value; }
        }

        public UsedCar(string make, string model, int year, double price, string used, double miles)
            : base(make, model, year, price)
        {
            this.used = used;
            this.miles = miles;
        }

        public override string ToString()
        {
            return base.ToString() + $"{used, 10} {miles}";
        }
    }
}
