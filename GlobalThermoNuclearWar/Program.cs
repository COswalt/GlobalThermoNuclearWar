using System;
using System.Threading;
namespace Global_Thermonuclear_War
{
    class program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8'};
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 = X, Player 2 = O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Turn");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, row [{0}] is already marked with [{1}]", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait, board is loading...");
                    Thread.Sleep(5000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player [1] is the winner.", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" [{0}] | [{1}] | [{2}] ", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine(" [{0}] | [{1}] | [{2}] ", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine(" [{0}] | [{1}] | [{2}] ", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |     ");
        }
        private static int CheckWin()
        {
        #region Horizontal Win Conditions
        if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return 1;
            }
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region Vertical Win Conditions
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            #endregion
            #region Diagonal Win Conditions
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return 1;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return 1;
            }
            #endregion
            #region Check For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
            return 0;
            }
            }

    }
}
