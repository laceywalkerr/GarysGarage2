using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public void RefuelTank()
    {
        //method definition
    }

    // public override void Drive()
    // {
    //     Console.WriteLine("zooooooooom!");
    // }

}