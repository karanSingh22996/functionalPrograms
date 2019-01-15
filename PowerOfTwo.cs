//-----------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class will generate the power table of the given number
    /// </summary>
   public class PowerOfTwo
   {
        /// <summary>
        /// Powers the specified n.
        /// </summary>
        /// <param name="n">The n.base number</param>
        /// <param name="p">The p.power</param>
        /// <returns>integer return type</returns>
        public int Power(int n, int p)
        {
            ////pow is declared to store the power of the num
            int pow = 1;
            ////while loop will iterate till 
            ////the value of  p reached to Zero
            while (p > 0)
            {
                pow = pow * n;
                p--;
            }

            return pow;
        }

        /// <summary>
        /// Powers the table.
        /// </summary>
        public void PowerTable()
        {
            ////taking user input to cal the table
            Console.WriteLine("Enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            ////iteration iterate till the complete table is printed
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(this.Power(2, i));
            }
        }
   }
}
