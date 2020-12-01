using System;

namespace GarysGarage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 100;
        public int CurrentTankPercentage { get; set; } = 75;

        public void RefuelTank()
        {
            Console.WriteLine($"Your Rams's tank is now filled to {this.FuelCapacity}%");
        }

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
}