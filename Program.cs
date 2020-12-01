using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        //SECOND SECTION OF GARYS GARAGE
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGas> gasVehicles = new List<IGas>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            // FIRST SECTION OF GARYS GARAGE
            // static void Main(string[] args)
            // {
            //     Cessna myCessna = new Cessna();
            //     Ram myRam = new Ram();
            //     Tesla myTesla = new Tesla();
            //     Zero myZero = new Zero();

            //     myCessna.Drive();
            //     myCessna.Turn("");
            //     myCessna.Stop();

            //     myRam.Drive();
            //     myRam.Turn("");
            //     myRam.Stop();

            //     myTesla.Drive();
            //     myTesla.Turn("");
            //     myTesla.Stop();

            //     myZero.Drive();
            //     myZero.Turn("");
            //     myZero.Stop();

            //     List<Vehicle> myGarage = new List<Vehicle>
            //     {
            //         myCessna,
            //         myRam,
            //         myTesla
            //     };

        }
    }
}