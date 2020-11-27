using System;
using System.IO;

namespace DewiseIT
{
    public class currentFollowers
    {
        public void getDataJson()
        {
            try
            {

                string currentFollowers = File.ReadAllText("../../../online_twitter.csv");
                Console.WriteLine("--------------------");
                Console.WriteLine("Local Twitter");
                Console.WriteLine("-----------");
                Console.WriteLine("Names: " + "Followers: ");
                Console.WriteLine("-----------");
                Console.Write(currentFollowers);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
