namespace ReflectionExercise
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public DateOnly Year { get; set; }
        public decimal Price { get; set; }
        public int QtyWheels { get; set; }
    }
}
