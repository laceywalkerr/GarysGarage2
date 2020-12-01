using System;

namespace GarysGarage
{
    public interface IGas
    {
        void RefuelTank();
        double FuelCapacity { get; set; }
        int CurrentTankPercentage { get; set; }
    }
}