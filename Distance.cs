//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class will calculate euclidean distance
    /// </summary>
   public class Distance
    {
        /// <summary>
        /// Euclidean this instance.
        /// </summary>
        /// This method calculate eucleadian distance and return calculated distance
        /// <returns> results returns square root </returns>
        public double Euclidean()
        {
            ////Taking x and y value from user 
            Console.WriteLine("Enter the x-values");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y-values");
            int y = Convert.ToInt32(Console.ReadLine());
            ////Here we are using Math.sqrt to calculate square root
            double results = Math.Sqrt((x * x) + (y * y));
            return results;
        }
   }
}
