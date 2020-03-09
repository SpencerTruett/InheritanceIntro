using System;

namespace inheritanceIntro
{
  public class Tesla : Vehicle
  {  // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    // Override (in conjunction with virtual elsewhere) overrides the default action
    public override void Drive()
    {
      Console.WriteLine("The Tesla goes...Bzzzzzzzzzzzzz!");
    }
    public override void Turn()
    {
      Console.WriteLine("The Tesla turns for you on autopilot");
    }
    public override void Stop()
    {
      Console.WriteLine("The Tesla stops for you on autopilot");
    }

  }
}