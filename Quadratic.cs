//-----------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class calculate the quadratic equations
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// cal the Quadratics Values.
        /// </summary>
        public void QuadraticCal()
        {
            try
            {
                ////Taking user input for the value of a,b and c.
                Console.WriteLine("Enter a-value:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b-value:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter c-value:");
                int c = Convert.ToInt32(Console.ReadLine());
                ////Print the quadratic equations
                Console.WriteLine("Quadratic equation: " + a + "x*X" + " + " + b + "x" + "+" + c);
                ////Calculate the discriminants
                double discrimants = (b * b) - (4 * a * c);
                ////For calculating roots we have to cal sqrt of discriminants
                ////so here we have used static methods to cal sqrt of math class
                double d = Math.Sqrt(discrimants);
                Console.WriteLine("Discrimants " + discrimants);
                ////formula to cal roots of quadratic equations
                double root1 = (-b + d) / (2 * a);
                double root2 = (-b - d) / (2 * a);
                Console.WriteLine("Root1 = " + root1);
                Console.WriteLine("Root2 = " + root2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
