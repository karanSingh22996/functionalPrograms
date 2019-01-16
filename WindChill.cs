//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class will calculate the WindChill 
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Effectives the temporary.
        /// </summary>
        public void EffectiveTemp()
        {
            try
            {
                ////taking user input for the fahrenheit 
                Console.WriteLine("Enter the temperature value in fahrenheit");
                double temp = Convert.ToDouble(Console.ReadLine());
                ////taking user input for the Velocity 
                Console.WriteLine("Enter the velocity of air  in mph");
                double vel = Convert.ToDouble(Console.ReadLine());
                ////calculating power using inbuilt static method pow of math class
                double v = Math.Pow(vel, 0.16);
                ////Here checking cond if input values are valid or not
                ////if valid if executed
                if ((temp < 50 && vel > 3) || vel < 120)
                {
                    ////formula to calculate winchill
                    double w = ((35.74 + 0.6215) * temp) + (((0.4275 * temp) - 35.75) * v);
                    Console.WriteLine("Windchill = " + w);
                }
                else
                {
                    Console.WriteLine("Enter value temp 0-50 and velocity 3-120");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
