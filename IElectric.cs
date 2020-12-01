using System;

namespace GarysGarage
{
    public interface IElectric
    {
        void ChargeBattery();
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
    }
}