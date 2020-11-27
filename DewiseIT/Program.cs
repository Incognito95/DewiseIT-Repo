using System;

namespace DewiseIT
{
    class Program
    {
        static void Main(string[] args)
        {
            // read file line by line
            LineByLine LineByLine = new LineByLine();
            LineByLine.ReadLineByLine(); // read file data
            
            // current followers online
            currentFollowers currentFollowers = new currentFollowers();
            currentFollowers.getDataJson();

            // Twitter followers online / local difference
            onlineAndLocalDifference onlineAndLocalDifference = new onlineAndLocalDifference();
            onlineAndLocalDifference.onlineAndLocalDifferenceSubtract();
               
            // TotalFollowersDiff
            TotalFollowersDiff TotalFollowersDiff = new TotalFollowersDiff();
            TotalFollowersDiff.TotalFollowersDiffSingleDigit();
        }

            

    }
}
