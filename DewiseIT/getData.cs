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

                string getDataLocal = File.ReadAllText("../../../local_twitter.csv");
                Console.WriteLine("Local Twitter");
                Console.WriteLine("-----------");
                Console.WriteLine("Names: " + "Followers: ");
                Console.WriteLine("-----------");
                Console.WriteLine(getDataLocal);
                
                string getDataOnline = File.ReadAllText("../../../online_twitter.csv");
                Console.WriteLine("--------------------");
                Console.WriteLine("Online Twitter");
                Console.WriteLine("-----------");
                Console.WriteLine("Names: " + "Followers: ");
                Console.WriteLine("-----------");
                Console.Write(getDataOnline);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}