//-----------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// program to print array in matrix form
    /// </summary>
    public class TwoDArray
    {
        /// <summary>
        /// Reads the array.
        /// </summary>
        /// <returns>returns integer type array</returns>
        public int[,] ReadArr()
        {
            ////taking user input to know the row and col size
            Console.WriteLine("Enter row size");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column size");
            int col = Convert.ToInt32(Console.ReadLine());
            ////Creating and decalaring the arra by
            ////passing to row and col size
            int[,] arr = new int[row, col];
            try
            {
                ////taking user input to print the elements of array
                Console.WriteLine("Enter " + (row * col) + "numbers");
                ////Iteration iterate till all the elements are stored in array
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return arr;
        }

        /// <summary>
        /// Displays the array.
        /// </summary>
        /// <param name="arr">integer type array.</param>
        public void DisplayArr(int[,] arr)
        {
            try
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}