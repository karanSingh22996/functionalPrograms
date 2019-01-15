//-----------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This programs will count and print all the
    /// prime factors of the given numbers    
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Primes this instance.
        /// </summary>
        public void Prime()
        {
           ////taking user input to take the number
            Console.WriteLine("Enter the number to find prime factors");
            int n = Utility.GetInt();
            ////listing all the prime factors of the given number
            Console.WriteLine("Prime Factors of " + n + " are:");
            ////iterating from 1 to the num to find factors 
           for (int i = 2; i <= n; i++)
            {
                ////checking if number is factor
                ////printing if num is factor
                if (n % i == 0 && Utility.IsPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
           }
        }
    }
}
