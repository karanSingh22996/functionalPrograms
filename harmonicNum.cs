//-----------------------------------------------------------------------
// <copyright file="HarmonicNum.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// this class will cal nth harmonic number
    /// </summary>
    public class HarmonicNum
    {
        /// <summary>
        /// Harmonics the results.
        /// </summary>
        public void HarmonicResults()
        {
            try
            {
                double sum = 0;
                ////taking user input to cal nth harmonic number
                Console.WriteLine("Enter the number till you want to get harmonic results");
                int n = Convert.ToInt32(Console.ReadLine());
                ////this iteration will iterate till
                ////our num raeched to nth position
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + (1.0 / i);
                }
                ////Printing harmoniv value of nth number
                Console.WriteLine(n + "th harmonic value = " + sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
