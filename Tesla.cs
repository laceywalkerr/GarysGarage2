using System;

public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine("The Red Tesla blazes by you. MMmmmmmmmmmmmmm!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine("The Tesla carefully turns right");
    }

    public override void Stop()
    {
        Console.WriteLine("The Tesla gently rolls to a stop");
    }
}