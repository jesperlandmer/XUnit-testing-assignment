using System;
using Xunit;

namespace XUnit_testing_assignment
{
    public class FoodTest
    {
        private readonly Food _food;

        public FoodTest()
        {
            _food = new Food();
        }

        [Fact]
        public void ShouldGetRandomPosition()
        {
            Position result = _food.FoodPosition;
            Position actual = new Position();

            Assert.False(result.XCoordinate == actual.XCoordinate);
            Assert.False(result.YCoordinate == actual.YCoordinate);
        }
    }
}
