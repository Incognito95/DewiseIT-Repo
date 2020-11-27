namespace DewiseIT
{
    class Program
    {
        static void Main(string[] args)
        {
            // read file line by line
            LineByLine lineByLine = new LineByLine();
            lineByLine.ReadLineByLine(); // read file data
            
            // current followers online
           CurrentFollowers currentFollowers = new CurrentFollowers();
           currentFollowers.getDataJson();

            // Twitter followers online / local difference
            OnlineAndLocalDifference onlineAndLocalDifference = new OnlineAndLocalDifference();
            onlineAndLocalDifference.OnlineAndLocalDifferenceSubtract();
               
            // TotalFollowersDiff
            TotalFollowersDiff totalFollowersDiff = new TotalFollowersDiff();
            totalFollowersDiff.TotalFollowersDiffSingleDigit();
        }
    }
}