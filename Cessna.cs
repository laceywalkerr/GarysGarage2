using System;
public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    // public void RefuelTank()
    // {
    //     // method definition omitted
    // }

    public override void Drive()
    {
        Console.WriteLine("The White Cessna flashes by you like a hurricane. Zzzzzzoooooooooommm!");
    }
}