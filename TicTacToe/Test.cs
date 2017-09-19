using NUnit.Framework;
using System.Linq;
using System;
namespace TicTacToe
{
    [TestFixture()]
    public class Test
    {
        private Grid _grid;

        [SetUp]
        public void Init()
        {
            _grid = new Grid();
        }

        [Test]
        public void CheckThatInitialGridIsEmpty()
        {
            Assert.True(_grid.GridIsEmpty());
        }

        [Test]
        public void CheckSettingValueWorks()
        {
            var coord = new Tuple<int, int>(1, 1);
            _grid[1, 1] = CrossDots.O;
            var populatedCoord = _grid.GetPopulatedCoord();

            Assert.AreEqual(_grid[coord.Item1,coord.Item2], CrossDots.O);
            Assert.AreEqual(populatedCoord.Count, 1);
            Assert.AreEqual(populatedCoord[0], coord);
        }
    }
}
