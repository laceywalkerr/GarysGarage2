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

    public override void Turn(string direction)
    {
        Console.WriteLine("The Ram carefully turns right");
    }

    public override void Stop()
    {
        Console.WriteLine("The Ram gently rolls to a stop");
    }
}