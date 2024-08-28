namespace CommonInterfaces
{
    public class Car : IComparable<Car>, IEquatable<Car>,ICloneable
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }
        public Car Manager { get; set; }

        public Car()
        {

        }

        public Car(string name, int maxMph, int horsepower, decimal price)
        {
            Name = name;
            MaxMph = maxMph;
            Horsepower = horsepower;
            Price = price;
        }

        public int CompareTo(Car? other)
        {
            if (other == null)
            {
                throw new ArgumentException("Is null");
            }
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"{Name} {MaxMph} {Horsepower} {Price}";
        }

        public bool Equals(Car? other)
        {
            return Name == other.Name && MaxMph == other.MaxMph && Horsepower == other.Horsepower && Price == other.Price;
        }

        public object Clone()
        {
            var car = new Car();
            car.Name =Name;
            car.MaxMph =MaxMph;
            car.Horsepower =Horsepower;
            car.Price =Price;
            car.Manager = Manager;

            return car;
        }
    }
}
