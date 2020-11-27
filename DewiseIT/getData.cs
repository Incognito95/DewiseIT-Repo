using System;
using System.IO;

namespace DewiseIT
{
    public class getData
    {
        public void getDataJson()
        {
            try
            {

                string getData = File.ReadAllText("../../../file_twitter.csv");
                Console.WriteLine("Names: " + "Followers: ");
                Console.WriteLine("-----------");
                Console.WriteLine(getData);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}