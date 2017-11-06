using System;
using Xunit;

namespace XUnit_testing_assignment.test
{
    public class PositionTest
    {
        private readonly src.Position _position;

        public PositionTest()
        {
            _position = new src.Position(0,0);
        }

        [Fact]
        public void ShouldReturnXCoordinate()
        {
            int result = _position.XCoordinate;
            int actual = 0;

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShouldReturnYCoordinate()
        {
            int result = _position.YCoordinate;
            int actual = 0;

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShouldThrowExceptionOnNegativePositionValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new src.Position(-1, -1));
        }
    }
}
