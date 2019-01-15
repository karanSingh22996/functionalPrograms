//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// This class will check whether the given year is leap or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Determines whether the specified year is leap.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if the specified year is leap; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeap(int year)
        {
            if ((year % 4 == 0 && year % 400 == 0) || (year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
