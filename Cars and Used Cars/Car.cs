using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0.0m;
        }
        public Car (string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Make,-10} {Model,-10} {Year,4} \t {Price:C}"; // -10 indicates width of 10 characters L-aligned, 4 indicates width of 4 characters R-aligned
        }

        public static List<Car> CarList = new List<Car>();
        public static void ListCars()
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                Console.WriteLine($"{i +1}: {CarList[i]}");
                Console.WriteLine();
            }
        }
        public static void Remove (int index)
        {
            int adjustedIndex = index - 1;
            CarList.RemoveAt(adjustedIndex);
        }
    }
}
