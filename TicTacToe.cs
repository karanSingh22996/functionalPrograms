//-----------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalProgrmas
{
    using System;

    /// <summary>
    /// the class will generate TicTacToe game 
    /// and give interface to the player and 
    /// give them choice to play
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// declaring instance variable count
        /// </summary>
        private int count = 0;

        /// <summary>
        /// declaring instance variable col
        /// </summary>
        private int col;

        /// <summary>
        /// declaring and initializing instance variable data 
        /// </summary>
        private int data = 0;

        /// <summary>
        /// declaring and initializing instance variable flag
        /// </summary>
        private int flag = 0;

        /// <summary>
        /// declaring row1 variable
        /// </summary>
        private int row1;

        /// <summary>
        /// declaring col1 variable
        /// </summary>
        private int col1;

        /// <summary>
        /// declaring and initializing array of character
        /// </summary>
        private char[,] a = new char[3, 3];

        /// <summary>
        /// using get set for row
        /// </summary>
        private int Row { get => this.Row1; set => this.Row1 = value; }

        /// <summary>
        /// using get and set for row1
        /// </summary>
        private int Row1 { get; set; }

        /// <summary>
        /// using get set for array of characters
        /// </summary>
        private char[,] A { get => this.a; set => this.a = value; }

        /// <summary>
        /// This method will give all the functionality 
        /// to make game more efficient and play smoothly
        /// </summary>
        public void Tic()
        {
            ////To avoid any exception
            try
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Player 1 is Computer and Player 2 is User");
                char m = '.';
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.A[i, j] = m;
                    }
                }

                while (this.count < 10)
                {
                    this.Comp();
                    Console.WriteLine("Count is..." + this.count + "\n\n");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(this.A[i, j] + "\t");
                        }

                        Console.WriteLine();
                    }

                    ////All the possible condition for win for computer
                    if (((this.A[0, 0] == 'X') && (this.A[1, 0] == 'X') && (this.A[2, 0] == 'X')) ||
                            ((this.A[0, 1] == 'X') && (this.A[1, 1] == 'X') && (this.A[2, 1] == 'X')) ||
                        ((this.A[0, 2] == 'X') && (this.A[1, 2] == 'X') && (this.A[2, 2] == 'X')) ||
                        ((this.A[0, 0] == 'X') && (this.A[0, 1] == 'X') && (this.A[0, 2] == 'X')) ||
                        ((this.A[1, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[1, 2] == 'X')) ||
                            ((this.A[2, 0] == 'X') && (this.A[2, 1] == 'X') && (this.A[2, 2] == 'X')) ||
                            ((this.A[0, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[2, 2] == 'X')) ||
                            ((this.A[2, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[0, 2] == 'X')))
                    { 
                        Console.WriteLine("You Win...");
                        Console.ReadKey();
                        return;
                    }
                    else if (((this.A[0, 0] == 'O') && (this.A[1, 0] == 'O') && (this.A[2, 0] == 'O')) ||
                ((this.A[0, 1] == 'O') && (this.A[1, 1] == 'O') && (this.A[2, 1] == 'O')) ||
            ((this.A[0, 2] == 'O') && (this.A[1, 2] == 'O') && (this.A[2, 2] == 'O')) ||
            ((this.A[0, 0] == 'O') && (this.A[0, 1] == 'O') && (this.A[0, 2] == 'O')) || ((this.A[1, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[1, 2] == 'O')) ||
            ((this.A[2, 0] == 'O') && (this.A[2, 1] == 'O') && (this.A[2, 2] == 'O')) ||
                ((this.A[0, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[2, 2] == 'O')) ||
                ((this.A[2, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[0, 2] == 'O')))
                    {
                        Console.WriteLine("You Loose...");
                        Console.ReadKey();
                        return;
                    }

                    if (this.count < 9)
                    {
                        this.User();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(this.A[i, j] + "\t");
                            }

                            Console.WriteLine();
                        }
                        ////All the possible condition for user to win
                        if (((this.A[0, 0] == 'X') && (this.A[1, 0] == 'X') && (this.A[2, 0] == 'X')) ||
                                    ((this.A[0, 1] == 'X') && (this.A[1, 1] == 'X') && (this.A[2, 1] == 'X')) ||
                                ((this.A[0, 2] == 'X') && (this.A[1, 2] == 'X') && (this.A[2, 2] == 'X')) ||
                                ((this.A[0, 0] == 'X') && (this.A[0, 1] == 'X') && (this.A[0, 2] == 'X')) ||
                                ((this.A[1, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[1, 2] == 'X')) ||
                                    ((this.A[2, 0] == 'X') && (this.A[2, 1] == 'X') && (this.A[2, 2] == 'X')) ||
                                    ((this.A[0, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[2, 2] == 'X')) ||
                                    ((this.A[2, 0] == 'X') && (this.A[1, 1] == 'X') && (this.A[0, 2] == 'X')))
                        {
                            Console.WriteLine("You Win...");
                            Console.ReadKey();
                            return;
                        }
                        else if (((this.A[0, 0] == 'O') && (this.A[1, 0] == 'O') && (this.A[2, 0] == 'O')) ||
                        ((this.A[0, 1] == 'O') && (this.A[1, 1] == 'O') && (this.A[2, 1] == 'O')) ||
                    ((this.A[0, 2] == 'O') && (this.A[1, 2] == 'O') && (this.A[2, 2] == 'O')) ||
                    ((this.A[0, 0] == 'O') && (this.A[0, 1] == 'O') && (this.A[0, 2] == 'O')) ||
                        ((this.A[1, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[1, 2] == 'O')) ||
                        ((this.A[2, 0] == 'O') && (this.A[2, 1] == 'O') && (this.A[2, 2] == 'O')) ||
                        ((this.A[0, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[2, 2] == 'O')) ||
                        ((this.A[2, 0] == 'O') && (this.A[1, 1] == 'O') && (this.A[0, 2] == 'O')))
                        {
                            Console.WriteLine("You Loose...");
                            Console.ReadKey();
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("><><><><>GAME OVER><><<><><");
                        Console.ReadKey();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(this.A[i, j] + "\t");

                                //// System.out.print(b[i][j]+"\t");  
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("Match draw...");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        /************************************************user function*****************************************************************/
        
        /// <summary>
        /// This method will ask user to enter his desire 
        /// move by giving row and col option
        /// </summary>
        public void User()
        {
            try
            {
                Console.WriteLine("Enter the Value of ROW(0-2)");
                this.Row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Value of COLOUMN(0-2)");
                this.col = Convert.ToInt32(Console.ReadLine());
                this.flag = 0;
                while (this.A[this.Row, this.col] != 'X' && this.A[this.Row, this.col] != 'O')
                {
                    this.A[this.Row, this.col] = 'X';
                    this.count++;
                    this.flag = 1;
                    break;
                }

                if (this.flag == 0)
                {
                    Console.WriteLine("Postion already occupied please Enter another Postion...");
                    this.User();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        /*************************************************Comp function***************************************************************/
        
        /// <summary>
        /// This method will ask Computer to enter his desire 
        /// move by giving row and col option
        /// </summary>
        public void Comp()
        {
            try
            {
                Random r1 = new Random();
                this.row1 = r1.Next(3);
                this.col1 = r1.Next(3);
                this.data = 0;
                while (this.A[this.row1, this.col1] != 'O' && this.A[this.row1, this.col1] != 'X')
                {
                    this.A[this.row1, this.col1] = 'O';
                    this.count++;
                    this.data = 1;
                    break;
                }

                if (this.data == 0)
                {
                    this.Comp();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}