using System;

namespace DewiseIT
{
    public class onlineAndFileDifference
    {
        public void onlineAndFileDifferences ()
        {
            try
            {
                double onlineTwitter = 86327209273.6; // online twitter followers
                uint fileTwitter = 4044973738; // file twitter followers

                var subTractFollowers = onlineTwitter - fileTwitter;
                
                
                Console.WriteLine("Difference between online and file twitter followers are: " + subTractFollowers);
                
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