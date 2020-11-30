using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public void RefuelTank()
    {
        Console.WriteLine("Refill method goes here");
    }

    // public override void Drive()
    // {
    //     Console.WriteLine("zooooooooom!");
    // }

}