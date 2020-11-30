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
            myCessna.Turn("");
            myCessna.Stop();

            myRam.Drive();
            myRam.Turn("");
            myRam.Stop();

            myTesla.Drive();
            myTesla.Turn("");
            myTesla.Stop();

            myZero.Drive();
            myZero.Turn("");
            myZero.Stop();

            List<Vehicle> myGarage = new List<Vehicle>
            {
                myCessna,
                myRam,
                myTesla
            };

        }
    }
}