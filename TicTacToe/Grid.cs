using System;

namespace TicTacToe
{

    public enum CrossDots
    {
        X = 1,
        O = 2
    }

    public class Grid
    {
        private CrossDots[,] _grid;

        public Grid()
        {
            _grid = new CrossDots[3, 3];
        }

        public bool GridIsEmpty()
        {
            foreach (CrossDots val in _grid)
            {
                if (val != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public CrossDots GetValueAt(int x, int y)
        {
            return _grid[x, y];
        }

        public void SetValueAt(int x, int y, CrossDots value)
        {
            _grid[x, y] = value;
        }
    }
}
