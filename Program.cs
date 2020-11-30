using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna myCessna = new Cessna();
            Ram myRam = new Ram();
            Tesla myTesla = new Tesla();
            Zero myZero = new Zero();

            myCessna.Drive();
            myRam.Drive();
            myTesla.Drive();
            myZero.Drive();

            List<Vehicle> myGarage = new List<Vehicle>
            {
                myCessna,
                myRam,
                myTesla
            };

        }
    }
}