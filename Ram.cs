using System;

namespace inheritanceIntro
{
  public class Ram : Vehicle
  {  // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
      Console.WriteLine("The Ram goes...Rumble Rumble!");
    }
    public override void Turn()
    {
      Console.WriteLine("The Ram slowly turns down the street");
    }
    public override void Stop()
    {
      Console.WriteLine("The Cessna gently rolls to a stop");
    }
  }
}