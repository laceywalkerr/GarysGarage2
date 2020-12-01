using System;
// Vehicle is the parent class, you may only have one parent class
// Cars in the vehicles folder are the children 
// IElectic and IGas are the interfaces
public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public virtual void Turn(string direction)
    {
        Console.WriteLine("The vehicle turns right.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The vehicle stops.");
    }
}