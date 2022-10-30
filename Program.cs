namespace tic_tac_toe
{
    class Program
    {
        static void Main()
        {
                        
            List<string> boardValues = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> rowOne = new List<string>{boardValues[0], boardValues[1], boardValues[2]};
            List<string> rowTwo = new List<string>{boardValues[3], boardValues[4], boardValues[5]};
            List<string> rowThree = new List<string>{boardValues[6], boardValues[7], boardValues[8]};
            List<string> columnOne = new List<string>{boardValues[0], boardValues[3], boardValues[6]};
            List<string> columnTwo = new List<string>{boardValues[1], boardValues[4], boardValues[7]};
            List<string> columnThree = new List<string>{boardValues[2], boardValues[5], boardValues[8]};
            List<string> diagonalOne = new List<string>{boardValues[0], boardValues[4], boardValues[8]};
            List<string> diagonalTwo = new List<string>{boardValues[2], boardValues[4], boardValues[6]};
            
            List<List<string>> winningCombos = new List<List<string>>{rowOne, rowTwo, rowThree, columnOne, columnTwo, columnThree, diagonalOne, diagonalTwo};

            string currentPlayer = "x";
            
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            bool isGameOver = false;
            while (!isGameOver)
            {
                if(currentPlayer == "x")
                    currentPlayer = "o";
                else
                    currentPlayer = "x";

                PrintBoard(boardValues);
                boardValues = GetPlayerMove(boardValues, currentPlayer);
                isGameOver = IsGameOver(boardValues, winningCombos);
                
            }

            if (currentPlayer == "x")
            {
                Console.WriteLine("x wins!");
            }
            else
            {
                Console.WriteLine("o wins!");
            }

        }

        static void PrintBoard(List<string> boardValues)
        {
            Console.WriteLine($"{boardValues[0]} | {boardValues[1]} | {boardValues[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{boardValues[3]} | {boardValues[4]} | {boardValues[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{boardValues[6]} | {boardValues[7]} | {boardValues[8]}");
        }

        static List<string> GetPlayerMove(List<string> boardValues, string currentPlayer)
        {
            Console.WriteLine($"Player {currentPlayer}, please enter a number between 1 and 9");
            string playerMove = Console.ReadLine();
            int playerMoveInt = int.Parse(playerMove);
            boardValues[playerMoveInt - 1] = currentPlayer;
            return boardValues;
        }   

        static bool IsGameOver(List<string> boardValues, List<List<string>> winningCombos)
        {
            bool isGameOver = false;
            foreach (List<string> combo in winningCombos)
            {
                if (combo[0] == combo[1] && combo[1] == combo[2])
                {
                    isGameOver = true;
                }
            }

            if (!boardValues.Contains("1") && !boardValues.Contains("2") && !boardValues.Contains("3") && !boardValues.Contains("4") && !boardValues.Contains("5") && !boardValues.Contains("6") && !boardValues.Contains("7") && !boardValues.Contains("8") && !boardValues.Contains("9"))
            {
                isGameOver = true;
            }

            return isGameOver;
        }
    }
}