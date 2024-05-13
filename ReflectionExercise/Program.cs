

using ReflectionExercise;
using System.Reflection;

var bike1 = new Bike();

Console.WriteLine(bike1);
Console.WriteLine(bike1.GetType().Name);

var bikeType = bike1.GetType();

Console.WriteLine("\n");

foreach (var prop in bikeType.GetProperties())
{
    Console.WriteLine("-----------");
    Console.WriteLine(prop.PropertyType);
    Console.WriteLine(prop.Name);
}

var bike2 = new Bike()
{
    HasShimanoParts = true,
    MaxSpeed = 100,
    Model = "GTS M1",
    Price = 1150,
    QtyWheels = 2,
    Year = DateOnly.FromDateTime(DateTime.Today)
};

Console.WriteLine("\n**********************");

var bike2Type = bike2.GetType();

Console.WriteLine("\n");

foreach (var prop in bike2Type.GetProperties())
{
    Console.WriteLine("-----------");
    Console.WriteLine(prop.PropertyType);
    Console.WriteLine(prop.Name);
    Console.WriteLine(prop.GetValue(bike2));
}

Console.WriteLine("\n----------------------------------------");

var type = typeof(Bike);

PropertyInfo propertySet = type.GetProperty("QtyWheels");
propertySet.SetValue(bike2, 4);
Console.WriteLine("Updating bike quantity wheels: ");
Console.WriteLine($"New of wheels: {bike2.QtyWheels}");

foreach (var prop in type.GetProperties())
{
    Console.WriteLine("-----------");
    Console.WriteLine(prop.PropertyType);
    Console.WriteLine(prop.Name);
    Console.WriteLine(prop.GetValue(bike2));
}

