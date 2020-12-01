using System;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; } = 100;
        public int CurrentChargePercentage { get; set; } = 25;

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla now charged to {this.BatteryKWh}KHw.");
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
}