using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnit_testing_assignment.test
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
            src.Position result = _snake.HeadPosition;
            src.Position actual = new src.Position(SnakeStub.INITIAL_XCOORDINATE, SnakeStub.INITIAL_YCOORDINATE);

            Assert.Equal(result.XCoordinate, actual.XCoordinate);
            Assert.Equal(result.YCoordinate, actual.YCoordinate);
        }
        [Fact]
        public void ExpectLastBodyPieceToBeBehindHead()
        {
            List<src.Position> SnakePos = _snake.Positions;

            src.Position result = SnakePos.Last();

            int x = SnakeStub.INITIAL_XCOORDINATE - 5;
            int y = SnakeStub.INITIAL_YCOORDINATE - 5;
            src.Position actual = new src.Position(x,y);

            Assert.Equal(result.XCoordinate, actual.XCoordinate);
            Assert.Equal(result.XCoordinate, actual.YCoordinate);
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
            Assert.Throws<ArgumentOutOfRangeException>(() => _snake.Set(0, new src.Position(0,0)));
        }
    }

    class SnakeStub : src.Snake
    {
        public const int INITIAL_LENGTH = 5;
        public const int INITIAL_XCOORDINATE = 10;
        public const int INITIAL_YCOORDINATE = 10;
    }
}
