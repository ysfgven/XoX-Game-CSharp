using XoX_Game;

class GameController
{
    private Player player1;
    private Player player2;
    private char[] board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    private Display display;

    public GameController(Display display)
    {
        this.display = display;
    }

    public void setupPlayers()
    {
        Console.Write("Enter name of Player 1: ");
        string name1 = Console.ReadLine();
        player1 = new Player(1, name1);

        Console.Write("Enter name of Player 2: ");
        string name2 = Console.ReadLine();
        player2 = new Player(2, name2);
    }

    public void makeMove(Player player, int index)
    {
        board[index] = player.GetId() == 1 ? 'X' : 'O';
    }

    public bool checkWin(Player player)
    {
        char symbol = player.GetId() == 1 ? 'X' : 'O';
        int[,] wins = new int[,]
        {
            {0,1,2},{3,4,5},{6,7,8},
            {0,3,6},{1,4,7},{2,5,8},
            {0,4,8},{2,4,6}
        };

        for (int i = 0; i < wins.GetLength(0); i++)
        {
            if (board[wins[i, 0]] == symbol && board[wins[i, 1]] == symbol && board[wins[i, 2]] == symbol)
                return true;
        }
        return false;
    }

    public void startGame()
    {
        Player currentPlayer = player1;
        bool gameOver = false;

        while (!gameOver)
        {
            display.board(board);

            Console.Write($"{currentPlayer.GetUserName()}, make your move (0-8): ");
            if (int.TryParse(Console.ReadLine(), out int move) && move >= 0 && move <= 8)
            {
                if (board[move] == ' ')
                {
                    makeMove(currentPlayer, move);

                    if (checkWin(currentPlayer))
                    {
                        display.board(board);
                        Console.WriteLine($"{currentPlayer.GetUserName()} wins!");
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayer = currentPlayer == player1 ? player2 : player1;
                    }
                }
                else
                {
                    Console.WriteLine("This space is already taken. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Enter a number between 0 and 8.");
            }
        }
    }
}
