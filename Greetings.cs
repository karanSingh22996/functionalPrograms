//-----------------------------------------------------------------------
// <copyright file="Greetings.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// Welcome user game by asking his name
    /// </summary>
    public class Greetings
    {
        /// <summary>
        /// Greetings this instance.
        /// </summary>
        public void Greeting()
        {
            try
            {
                ////taking string user input
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                ////printing the welcomes notes
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Give proper data");
                }
                else
                {
                    Console.WriteLine("Hello " + name + " How are you?");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
