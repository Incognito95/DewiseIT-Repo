using System;

namespace DewiseIT
{
    class Program
    {
        static void Main(string[] args)
        {
              // get Data
              getData getData = new getData();
              getData.getDataJson();
              
              // read file
              readFileData readFileData = new readFileData();
              readFileData.readFileDataZip(); // read file data
               
               // Twitter followers online / file difference
               onlineAndFileDifference onlineAndFileDifference = new onlineAndFileDifference();
               onlineAndFileDifference.onlineAndFileDifferences();
               
               // TotalFollowersDiff
               TotalFollowersDiff TotalFollowersDiff = new TotalFollowersDiff();
               TotalFollowersDiff.TotalFollowersDiffSingleDigit();
        }

            

    }
}
