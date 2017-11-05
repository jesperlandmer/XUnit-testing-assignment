using System;
using Xunit;

namespace XUnit_testing_assignment
{
    public class PositionTest
    {
        private readonly Position _position;

        public PositionTest()
        {
            _position = new Position(0,0);
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
    }
}
