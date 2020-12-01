using System;

namespace GarysGarage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; } = 100;
        public int CurrentTankPercentage { get; set; } = 50;

        public void RefuelTank()
        {
            Console.WriteLine($"Your Cessna's tank is now filled to {this.FuelCapacity}%");
        }

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
}