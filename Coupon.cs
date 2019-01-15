//-----------------------------------------------------------------------
// <copyright file="Coupon.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// The class is use to generate number of unique coupons and will give output a number of random function called
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Distinct the coupon.
        /// </summary>
        public void DistinctCoupon()
        {
            Random random = new Random();

            //// Gets the input to generate number of distinct coupons
            Console.WriteLine("How many distinct number you want to generate");
            int n = Utility.GetInt();

            //// Array is used to store all random number of coupons
            int[] distict = new int[n];
            int count = 0;

            //// this loop will iterate to generate number of coupons user need
            for (int i = 0; i < distict.Length; i++)
            {
                count++;
                ////Generated numbers are assign in ran var 
                int ran = Convert.ToInt32(random.Next(0, n));
                ////all the distinct generated numbers are stored inside distinct array
                distict[i] = ran;

                ////This iteration is use if generated are numbers are repeated
                ////if repeated this will discard that num
                ////and sub value of i by -1
                for (int j = 0; j < i; j++)
                {
                    ////Checking if i value is equal or not
                    if (distict[i] == distict[j])
                    {
                        i--;
                    }
                }
            }

            Console.WriteLine("Total number of time it takes to generate random num is " + count);

            Console.WriteLine("Generated distinct numbers are:");
            ////Iteration is use to print all the distinct random numbers
            for (int i = 0; i < distict.Length; i++)
            {
                Console.WriteLine(distict[i] + " ");
            }
        }
    }
}
