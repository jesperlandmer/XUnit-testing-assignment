using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnit_testing_assignment
{
    public class SnakeTest
    {
        private readonly SnakeStub _snake;

        public SnakeTest()
        {
            _snake = new SnakeStub();
        }

        [Fact]
        public void ShouldReturnSnakeInitialLength()
        {
            int result = _snake.Length;
            int actual = SnakeStub.INITIAL_LENGTH;

            Assert.Equal(result, actual);
        }
        [Fact]
        public void ShouldReturnSnakeHeadInitialPosition()
        {
            Position result = _snake.HeadPosition;
            Position actual = new Position(SnakeStub.INITIAL_XCOORDINATE, SnakeStub.INITIAL_YCOORDINATE);

            Assert.Equal(result, actual);
        }
        [Fact]
        public void ExpectLastBodyPieceToBeBehindHead()
        {
            List<Position> SnakePos = _snake.Positions;

            Position result = SnakePos.Last();

            int x = SnakeStub.INITIAL_LENGTH - 5;
            int y = SnakeStub.INITIAL_LENGTH - 5;
            Position actual = new Position(x,y);

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShouldReturnSnakeLengthAfterGrow()
        {
            _snake.GrowSnake();
            int result = _snake.Length;
            int actual = 5 + 1;

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShouldThrowExceptionOnSnakeLengthOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _snake.Set(0, new Position(0,0)));
        }
    }

    class SnakeStub : Snake
    {
        public const int INITIAL_LENGTH = 5;
        public const int INITIAL_XCOORDINATE = 10;
        public const int INITIAL_YCOORDINATE = 10;
    }
}
