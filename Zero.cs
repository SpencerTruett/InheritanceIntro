using System;

namespace inheritanceIntro
{
  public class Zero : Vehicle
  {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine("The Zero goes...Vroom!");
    }
    public override void Turn()
    {
      Console.WriteLine("The Zero turns on a dime");
    }
    public override void Stop()
    {
      Console.WriteLine("The Zero pops a wheely when making a quick stop");
    }
  }
}