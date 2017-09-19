using System;
namespace TicTacToe
{
    public class Game
    {
        private Grid _grid;
        private readonly CrossDots player1;
        private readonly CrossDots player2;
        private bool _currentIsPlayer1;

        public Game()
        {
            _grid = new Grid();
            player1 = CrossDots.O;
            player2 = CrossDots.X;

        }

        public void Play()
        {
            Console.WriteLine("Player1: O");
            Console.WriteLine("Player2: X");
            Console.WriteLine("Player1 goes first");
            _currentIsPlayer1 = true;
            while (true)
            {
                var currentPlayerName = _currentIsPlayer1 ? "player1" : "player2";
                var currentPlayer = _currentIsPlayer1 ? player1 : player2;
                Tuple<int, int> coord;
                while (true)
                {
                    var populatedCoords = _grid.GetPopulatedCoord();

                    Console.WriteLine($"{currentPlayerName}, choose your coordinates");
                    var coordinates = Console.ReadLine();
                    coordinates = coordinates.Trim();
                    var twoCoord = coordinates.Split(new char[] { ',', ' ' });
                    if (twoCoord.Length != 2) continue;
                    try
                    {
                        int row = int.Parse(twoCoord[0]);
                        int column = int.Parse(twoCoord[1]);
                        coord = new Tuple<int, int>(row, column);

                        if (populatedCoords.Contains(coord))
                        {
                            Console.WriteLine($"Coordinates {coord} is already taken.");
                            continue;
                        }
                    }
                    catch (FormatException) { continue; }
                    break;
                }

                _grid[coord.Item1, coord.Item2] = currentPlayer;
                _currentIsPlayer1 = !_currentIsPlayer1;
            }
        }
    }
}
