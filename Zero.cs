using System;
public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        Console.WriteLine($"Your Zero now charged to {this.BatteryKWh}KHw.");
    }

    public override void Drive()
    {
        Console.WriteLine("The Midngiht Blue Zero Speeds past you. Yeeeeeeooowww!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine("The Zero carefully turns right");
    }

    public override void Stop()
    {
        Console.WriteLine("The Zero gently rolls to a stop");
    }
}