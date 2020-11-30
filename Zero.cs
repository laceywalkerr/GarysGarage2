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
}