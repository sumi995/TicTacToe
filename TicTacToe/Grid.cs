using System;
using System.Linq;
using System.Collections.Generic;

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
        public CrossDots this[int x, int y]
        {
            get
            {
                return _grid[x, y];
            }
            set
            {
                _grid[x, y] = value;    
            }
        }

        public Grid()
        {
            _grid = new CrossDots[3, 3];
        }

        internal bool GridIsEmpty()
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

        internal List<Tuple<int, int>> GetPopulatedCoord()
        {
            var populatedCoord = new List<Tuple<int, int>>();
            for (int i = 0; i < _grid.GetLength(0); i++)
            {
                for (int j = 0; j < _grid.GetLength(1); j++)
                {
                    if (_grid[i, j] != 0)
                    {
                        populatedCoord.Add(new Tuple<int, int>(i, j));
                    }

                }
            }
            return populatedCoord;
        }

    }
}
