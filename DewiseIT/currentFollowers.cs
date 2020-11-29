using System;
using System.IO;

namespace DewiseIT
{
    public class CurrentFollowers
    {
        public void getDataJson()
        {
            try
            {

                // path to file
                string currentFollowers = File.ReadAllText("../../../online_twitter.csv"); // import file with current followers
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
