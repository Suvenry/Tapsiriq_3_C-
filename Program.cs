using System;
using System.Collections.Generic;

class Vehicle
{
    public string Brand;
    public int Speed;

    public Vehicle() { }

    public virtual void MakeSound()
    {
        Console.WriteLine("Nəqliyyat vasitəsinin səsi...");
    }
}

class Car : Vehicle
{
    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public override void MakeSound()
    {
        Console.WriteLine(Brand + " (Avtomobil): Vroom vroom!");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public override void MakeSound()
    {
        Console.WriteLine(Brand + " (Motosiklet): Da-da-da-da!");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public override void MakeSound()
    {
        Console.WriteLine(Brand + " (Velosiped): Zırr zırr!");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car("BMW", 220));
        vehicles.Add(new Motorcycle("Yamaha", 180));
        vehicles.Add(new Bicycle("Stels", 30));

        foreach (Vehicle v in vehicles)
        {
            v.MakeSound();
        }
    }
}