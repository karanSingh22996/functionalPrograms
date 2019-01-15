//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
        using System;

        /// <summary>
        /// This class is created to run all the class in The project
        /// Only you need to select your desired program to execute
        /// </summary>
     public class Program
     {
        //// <summary>
        //// Main start from here and our program execution starts from here
        //// </summary>
        ////<param name="args">this program has no return type</param>
       public static void Main(string[] args)
       {
            string ans = null;
            do
            {
                Console.WriteLine("Press 1. For Greetings Program");
                Console.WriteLine("Press 2. For FlipCoins Programs");
                Console.WriteLine("Press 3. For Leap Year Programs");
                Console.WriteLine("Press 4. For Power of two Programs");
                Console.WriteLine("Press 5. For Harmonic value Programs");
                Console.WriteLine("Press 6. For Prime Factors Programs");
                Console.WriteLine("Press 7. For Gambler Programs");
                Console.WriteLine("Press 8. For Coupon Programs");
                Console.WriteLine("Press 9. For Two D Array Programs");
                Console.WriteLine("Press 10. For Sum of three num = 0 Programs");
                Console.WriteLine("Press 11. For Distance Programs");
                Console.WriteLine("Press 12. For Permutation of string Programs");
                Console.WriteLine("Press 13. For Elapsed Time Programs");
                Console.WriteLine("Press 14. For Quadratic Programs");
                Console.WriteLine("Press 15. For Windchill Programs");
                Console.WriteLine("Press 16. For TicTacToe Programs");

                ////Taking user input choice to execute the programs
                int n = Convert.ToInt32(Console.ReadLine());
                ////Switch will take you to the num which is given by user
                ////Where in every case we have created the object of every class and
                ////called the method created inside the class
                switch (n)
                {
                    case 1:
                        Greetings greetings = new Greetings();
                        greetings.Greeting();
                        break;
                    case 2:
                        FlipCoins fc = new FlipCoins();
                        fc.FlipResults();
                        break;
                    case 3:
                        LeapYear ly = new LeapYear();
                        Console.WriteLine("Enter year to check is leap or not");
                        int year = Convert.ToInt32(Console.ReadLine());
                        bool res = ly.IsLeap(year);
                        if (res)
                        {
                            Console.WriteLine(year + " is Leap year");
                        }
                        else
                        {
                            Console.WriteLine(year + " is not Leap Year");
                        } 

                        break;
                    case 4:
                        PowerOfTwo pt = new PowerOfTwo();
                        int[] a = new int[2];
                        pt.PowerTable();
                        break;
                    case 5:
                        HarmonicNum hn = new HarmonicNum();
                        hn.HarmonicResults();
                        break;
                    case 6:
                        PrimeFactors pf = new PrimeFactors();
                        pf.Prime();
                        break;
                    case 7:
                        Gambler gambler = new Gambler();
                        gambler.GamblingResults();
                        break;
                    case 8:
                        Coupon coupon = new Coupon();
                        coupon.DistinctCoupon();
                        break;
                    case 9:
                        TwoDArray twoD = new TwoDArray();
                        int[,] narr = twoD.ReadArr();
                        twoD.DisplayArr(narr);
                        break;
                    case 10:
                        SumOfThreeArray sot = new SumOfThreeArray();
                        sot.SumOfNum();
                        break;
                    case 11:
                        Distance d = new Distance();
                        double cal = d.Euclidean();
                        Console.WriteLine("Euclidean Results = " + cal);
                        break;
                    case 12:
                        PermutationOfStrings pos = new PermutationOfStrings();
                        string st = Console.ReadLine();
                        Console.WriteLine("Enter string");
                        pos.Permute(st, 0, st.Length - 1);
                        break;
                    case 13:
                        Elapsed elapsed = new Elapsed();
                        elapsed.ElapsedTime();
                        break;
                    case 14:
                        Quadratic quad = new Quadratic();
                        quad.QuadraticCal();
                        break;
                    case 15:
                        WindChill wc = new WindChill();
                        wc.EffectiveTemp();
                        break;
                    case 16:
                        TicTacToe ticTacToe = new TicTacToe();
                       
                        ticTacToe.Tic();
                        break;
                }

                Console.WriteLine("Do you want to run another Program (yes/no)");
                ans = Console.ReadLine();
            }
            while (ans != "n");
            Console.ReadLine();
        } 
       }
}
