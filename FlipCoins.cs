//-----------------------------------------------------------------------
// <copyright file="FlipCoins.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class is used for calculating the percentage of 
    /// head and tails of flipped coins
    /// </summary>
    public class FlipCoins
    {
        /// <summary>
        /// Flips the results.
        /// </summary>
        public void FlipResults()
        {
            ////taking user input 
            Console.WriteLine("How many times you want to flip coin");
            int num = Convert.ToInt32(Console.ReadLine());
            int hcount = 0;
            int tcount = 0;
            ////using random class to generate random numbers
            Random r = new Random();
            ////iteration is use to generate total num of times 
            ////coins flipping
            for (int i = 1; i <= num; i++)
            {
                ////taking user input to flip coin
                Console.WriteLine("Press any key to flip coins");
                Console.ReadLine();
                ////random generated num is stored inside n
                int n = Convert.ToInt32(r.Next(0, 2));
                if (n == 1)
                {
                    hcount++;
                    Console.WriteLine("It's Heads");
                }
                else
                {
                    tcount++;
                    Console.WriteLine("Oops u got tails");
                }
            }
            ////Calculating percenatge of heads and tails
            int perOfHeads = (hcount * 100) / num;
            int perOfTails = (tcount * 100) / num;
            ////Printing calculated percentage
            Console.WriteLine("Percentage of heads: " + perOfHeads);
            Console.WriteLine("Percentage of Tails: " + perOfTails);
        }
    }
}
