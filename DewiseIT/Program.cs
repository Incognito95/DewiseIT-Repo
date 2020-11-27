using System;

namespace DewiseIT
{
    class Program
    {
        static void Main(string[] args)
        {
            // read file line by line
           // LineByLine LineByLine = new LineByLine();
          //  LineByLine.ReadLineByLine(); // read file data
            
            // current followers online
          //  CurrentFollowers currentFollowers = new CurrentFollowers();
          //  currentFollowers.getDataJson();

            // Twitter followers online / local difference
           // OnlineAndLocalDifference onlineAndLocalDifference = new OnlineAndLocalDifference();
          //  onlineAndLocalDifference.onlineAndLocalDifferenceSubtract();
               
            // TotalFollowersDiff
            TotalFollowersDiff TotalFollowersDiff = new TotalFollowersDiff();
            TotalFollowersDiff.TotalFollowersDiffSingleDigit();
        }
    }
}
