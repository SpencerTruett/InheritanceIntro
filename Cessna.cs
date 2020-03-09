using System;

namespace inheritanceIntro
{
  public class Cessna : Vehicle
  {  // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
      Console.WriteLine("The Cessna goes...Pfftpfftpfft!");
    }
    public override void Turn()
    {
      Console.WriteLine("The Cessna makes a smooth bank mid-air");
    }
    public override void Stop()
    {
      Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway");
    }
  }
}