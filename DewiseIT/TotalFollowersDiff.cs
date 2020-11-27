using System;

namespace DewiseIT
{
    public class TotalFollowersDiff
    {
        public void TotalFollowersDiffSingleDigit()
        {
            double onlineTwitter = 86327209273.6; // online twitter followers
            uint localTwitter = 4044973738; // local twitter followers

            // log total of difference to console
            var totalFollowersDiff = onlineTwitter + localTwitter;

            // log total difference in decimal number to console
            Console.WriteLine("Total followers difference in decimal number is: " +  totalFollowersDiff);
            
            // round total difference to the nearest whole number
            Console.WriteLine("Total followers difference in whole number is: " + Math.Round(11.6, 0));
            
            
        }
    }
}
