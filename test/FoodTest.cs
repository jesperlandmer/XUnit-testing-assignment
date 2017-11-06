using System;
using Xunit;

namespace XUnit_testing_assignment.test
{
    public class FoodTest
    {
        private readonly src.Food _food;

        public FoodTest()
        {
            _food = new src.Food();
        }

        [Fact]
        public void ShouldGetRandomPosition()
        {
            src.Position result = _food.FoodPosition;
            src.Position actual = new src.Position();

            Assert.False(result.XCoordinate == actual.XCoordinate);
            Assert.False(result.YCoordinate == actual.YCoordinate);
        }
    }
}
