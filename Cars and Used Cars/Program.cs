using Cars_and_Used_Cars;

Car car1 = new Car("Audi", "Q6", 2024, 45000m);
Car car2 = new Car("Mazda", "CX-5", 2023, 35000m);
Car car3 = new Car("Honda", "Accord", 2025, 25000m);
UsedCar usedCar1 = new UsedCar("Toyota", "Camry", 2010, 15000m, 100000);
UsedCar usedCar2 = new UsedCar("Nissan", "Altima", 2015, 18000m, 80000);
UsedCar usedCar3 = new UsedCar("Ford", "Escape", 2020, 20000m, 75000);

Car.CarList.Add(car1);
Car.CarList.Add(car2);
Car.CarList.Add(car3);
Car.CarList.Add(usedCar1);
Car.CarList.Add(usedCar2);
Car.CarList.Add(usedCar3);

Console.WriteLine("Welcome to Rebeccah's dealership! Here are the available cars for purchase:");
Console.WriteLine();
Car.ListCars();

bool validIndex = false;
do
{
    Console.WriteLine("Which car would you like to buy? Enter 1-6");
    int index = int.Parse(Console.ReadLine());
    if (index >= 1 && index <= Car.CarList.Count)
    {
        Console.WriteLine($"You have chosen the following car:\n{Car.CarList[index-1]}"); // \n = line break
        Car.Remove(index);
        Console.WriteLine("Our finance department will be in touch shortly!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid index. Please enter 1-6");
    }
} while (validIndex == false);

Console.WriteLine();
Console.WriteLine("Press any key to see the remaining cars available for purchase:");
Console.ReadKey();
Console.WriteLine();
Car.ListCars();

// How can inheritance increase the scalability of your project?

// Inheritance increases scalability in a few ways. First, it allows for commonly used code in an application to be written once in a base class and then shared among
// several derived classes. This ensures that shared code only needs to be maintained in one place rather than being repeated in every subclass. Because of this, most
// maintenance can be done in the base class as all derived classes will inherit the changes made. Also, subclasses can be added if desired without modifying exisiting
// functionality.