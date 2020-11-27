using System;

namespace DewiseIT
{
    public class TotalFollowersDiff
    {
        public void TotalFollowersDiffSingleDigit()
        {
            double onlineTwitter = 86327209273.6; // online twitter followers
            uint fileTwitter = 4044973738; // file twitter followers

            var totalFollowersDiff = onlineTwitter + fileTwitter;

            // total followers diff in decimal number
            Console.WriteLine("Total followers difference in decimal number is: " +  totalFollowersDiff);
            
            // round to the nearest whole number
            Console.WriteLine("Total followers difference in whole number is: " + Math.Round(11.6, 0));





        }
    }
}
