using System;
using Xunit;

namespace XUnit_testing_assignment.test
{
    public class GameTest
    {
        private readonly GameStub _game;

        public GameTest()
        {
            _game = new GameStub();
        }

        [Fact]
        public void ShouldFeedSnake()
        {
            _game.FeedSnake();

            int result = _game.Snake.Length;
            int actual = new src.Snake().Length + 1;

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShouldReturnLeftDirection()
        {
            _game.SetDirection(src.Game.Controls.Left);
            src.Game.Controls result = _game.Snake.Direction;
            src.Game.Controls actual = src.Game.Controls.Left;

            Assert.Equal((int)result, (int)actual);
        }
    }

    class GameStub : src.Game
    {
        public bool IsSnakeFed()
        {
            return true;
        }
    }
}
