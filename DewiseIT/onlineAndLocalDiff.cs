using System;

namespace DewiseIT
{
    public class OnlineAndLocalDifference
    {
        public void OnlineAndLocalDifferenceSubtract()
        {
            try
            {
                double onlineTwitter = 86327209273.6; // online twitter followers
                uint localTwitter = 4044973738; // local twitter followers

                // subtract online and local twitter followers to find the difference
                var subTractFollowers = onlineTwitter - localTwitter; 
                
                // log difference to console
                Console.WriteLine("Difference between online and local twitter followers are: " + subTractFollowers);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}