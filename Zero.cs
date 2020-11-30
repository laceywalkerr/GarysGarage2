using System;
public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        Console.WriteLine($"Your Zero now charged to {this.BatteryKWh}KHw.");
    }
}