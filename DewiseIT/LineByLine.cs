using System;
using System.IO;

namespace DewiseIT
{
    public class LineByLine
    {
        public void ReadLineByLine()
        {
            try
            {

                // path to file
                string currentFollowers = File.ReadAllText("../../../data.json"); // import data file text, read file to the end
                Console.WriteLine("Names: " + "Followers:");
                Console.WriteLine("----------------------");
                Console.Write(currentFollowers); // log file to console of both the names and followers

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}