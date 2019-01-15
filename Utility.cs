//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// Utility class are designed to use repeated function again and again inside other classes 
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// This method will return integer data
        /// </summary>
        /// <returns>return integer</returns>
        public static Int32 GetInt()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        /// <summary>
        /// This method will return string data.
        /// </summary>
        /// <returns>return string</returns>
        public static string GetString()
        {
            string st = Console.ReadLine();
            return st;
        }

        /// <summary>
        /// Random function are used here to generate random numbers
        /// </summary>
        /// <returns>return integer random numbers</returns>
        public static int GetRandom()
        {
            Random random = new Random();
            return Convert.ToInt32(random.Next(3));
        }

        /// <summary>
        /// IsPrime method is use to check whether
        /// the given number is prime or not
        /// </summary>
        /// <param name="n">integer parameter</param>
        /// <returns>return boolean true or false</returns>
        public static bool IsPrime(int n)
        {
            bool res = false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return res;
                }
            }

            return true;
        }
    }
}
