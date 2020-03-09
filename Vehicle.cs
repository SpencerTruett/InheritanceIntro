using System;

namespace inheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaxOccupancey { get; set; }

    // The word virtual gives permission to the child to override the default action
    public virtual void Drive()
    {
      Console.WriteLine("Vroom!!!");
    }
    public virtual void Turn()
    {
      Console.WriteLine("We're akin' another left turn...");
    }
    public virtual void Stop()
    {
      Console.WriteLine("Sceeeeeeeech! Crash!");
    }
  }
}