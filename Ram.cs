using System;

public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }

    // public void RefuelTank()
    // {
    //     // method definition omitted
    // }

    public override void Drive()
    {
        Console.WriteLine("The Silver Ram growls by you. Rrrrrrruuuummmbbble!");
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