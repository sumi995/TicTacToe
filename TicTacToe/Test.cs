using NUnit.Framework;
using System;
namespace TicTacToe
{
    [TestFixture()]
    public class Test
    {
        private Grid _grid;

        [SetUp]
        public void init()
        {
            _grid = new Grid();
        }

        [Test]
        public void checkThatInitialGridIsEmpty()
        {
            Assert.True(_grid.GridIsEmpty());
        }
    }
}
