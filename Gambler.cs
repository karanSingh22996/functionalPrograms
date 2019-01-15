//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class calculate the gambling results
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gambling the results.
        /// </summary>
        public void GamblingResults()
        {
            ////Taking value from user for stakes,goal and num of times he want to play
            Console.WriteLine("How much stakes do you have?");
            int stake = Utility.GetInt();
            Console.WriteLine("How much is your goal?");
            int goal = Utility.GetInt();
            int setGoal = goal;
            Console.WriteLine("In how many times You want reach your goal?");
            int noOfTimes = Utility.GetInt();
            int numOfWins = 0;
            int numOfLoss = 0;
            ////Random class to generate random numbers
            Random random = new Random();
            int sum = 0;
            ////Iteration start till the number of times
            for (int i = 1; i <= noOfTimes; i++)
            {
                ////Taking user input to play
                Console.WriteLine("Press any key to play:");
                Console.ReadLine();
                ////random num is stored inside num variable
                int num = Convert.ToInt32(random.Next(0, 2));
                Console.WriteLine(" You got :" + num);
                if (num == 1)
                {
                    sum = sum + 1;
                    numOfWins++;
                    Console.WriteLine("You Reached " + sum);
                }
                else
                {
                    goal = stake - 1;
                    numOfLoss++;
                    Console.WriteLine("You Reached " + goal);
                }

                if (setGoal == sum)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (goal == 0)
                {
                    Console.WriteLine("You are broke now,Time to quit game");
                    break;
                }
            }
            ////cal percentage of win and loss
            int perOfWin = (numOfWins * 100) / noOfTimes;
            int perOfLoss = (numOfLoss * 100) / noOfTimes;
            ////Printing the calculated resuls
            Console.WriteLine("Percentage of wins: " + perOfWin);
            Console.WriteLine("Percentage of Loss: " + perOfLoss);
        }
    }
}
