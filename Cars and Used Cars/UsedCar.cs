using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }
        public UsedCar (string make, string model, int year, decimal price, double mileage): base(make, model, year, price)
        {
            Mileage = mileage;
        }
        public override string ToString()
        {
            return $"{base.ToString()} (Used) {Mileage:N1} miles"; // N1 shows to one decimal place
        }
    }
}
