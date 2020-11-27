using System;

namespace DewiseIT
{
    public class OnlineAndLocalDifference
    {
        public void onlineAndLocalDifferenceSubtract()
        {
            try
            {
                double onlineTwitter = 86327209273.6; // online twitter followers
                uint localTwitter = 4044973738; // local twitter followers

                var subTractFollowers = onlineTwitter - localTwitter;
                
                
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

// online twitter - 86327209273.6 followers
// file twitter - 4044973738 followers