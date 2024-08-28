using CommonInterfaces;
using System.Diagnostics;
using System.Xml.Linq;

Car[] car = { new Car { Name = "Porsche", MaxMph = 360, Horsepower = 500, Price = 85000 }, new Car { Name = "Bentley", MaxMph = 360, Horsepower = 400, Price = 400000 } };
PersonComparer personComparer = new PersonComparer();
Array.Sort(car, personComparer);
foreach (var item in car)
{
    Console.WriteLine(item);
}

List<Car> list = new List<Car> { new Car { Name = "Porsche", MaxMph = 360, Horsepower = 500, Price = 85000 }, new Car { Name = "Bentley", MaxMph = 360, Horsepower = 400, Price = 400000 } };
var car1 = new Car { Name = "Porsche", MaxMph = 360, Horsepower = 500, Price = 85000 };
Console.WriteLine(car.Contains(car1));

Car car2 = new Car("Cullinan", 300, 450, 500000);
car2.Manager = new Car("Bentayga", 350, 500, 450000);
Car other = (Car)car2.Clone();
car2.Manager.Name = "BMW";
Console.WriteLine(other.Manager.Name);