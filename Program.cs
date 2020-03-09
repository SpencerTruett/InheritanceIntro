using System;

namespace inheritanceIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      var myBike = new Zero();

      // I can still refer to the inherited property
      myBike.MainColor = "Black";
      myBike.MaxOccupancey = 2;

      var myTesla = new Tesla();

      myTesla.MainColor = "Midnight Silver";
      myTesla.MaxOccupancey = 6;

      var myRam = new Ram();

      myRam.MainColor = "Candy Apple Red";
      myRam.MaxOccupancey = 5;

      var myCessna = new Cessna();

      myCessna.MainColor = "Olive Green";
      myCessna.MaxOccupancey = 4;

      myBike.Drive();
      myBike.Turn();
      myBike.Stop();
      myTesla.Drive();
      myTesla.Turn();
      myTesla.Stop();
      myRam.Drive();
      myRam.Turn();
      myRam.Stop();
      myCessna.Drive();
      myCessna.Turn();
      myCessna.Stop();

    }
  }
}
