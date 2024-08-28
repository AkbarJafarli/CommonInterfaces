namespace CommonInterfaces
{
    public class PersonComparer : IComparer<Car>
    {
        public enum CompareField
        {
            Name,
            MaxMph,
            Horsepower,
            Price
        }
        public CompareField SortBy = CompareField.Name;
        public int Compare(Car? x, Car? y)
        {
            switch (SortBy)
            {
                case CompareField.Name:
                    return x.Name.CompareTo(y.Name);
                case CompareField.MaxMph:
                    return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.Horsepower:
                    return x.Horsepower.CompareTo(y.Horsepower);
                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
                default: break;
            }
            return x.Name.CompareTo(y.Name);
        }
    }
}
