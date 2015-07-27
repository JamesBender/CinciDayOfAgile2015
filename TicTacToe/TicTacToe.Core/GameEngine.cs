namespace TicTacToe.Core
{
    public class GameEngine
    {
        public string GetWinner(string[,] board)
        {
            return board[0, 0];
        }
    }
}
