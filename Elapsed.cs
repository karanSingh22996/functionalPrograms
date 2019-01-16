//-----------------------------------------------------------------------
// <copyright file="Elapsed.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    /// <summary>
    /// This class will calculate the elapsed time between the
    /// start and end of the program.
    /// </summary>
    public class Elapsed
    {
        /// <summary>
        /// Cal  the Elapsed time.
        /// </summary>
        public void ElapsedTime()
        {
            try
            {
                ////stopwatch is inbuilt class for that we have used diagnostics package 
                Stopwatch stopwatch = new Stopwatch();
                ////start() is static method in stopwatch class
                stopwatch.Start();
                ////for delay we have static sleep method of thread class
                Thread.Sleep(1500);
                ////stop() is also static method in stopwatch class
                stopwatch.Stop();
                ////finally we are calculating and printing elpased time during program execution
                Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
