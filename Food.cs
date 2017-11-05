using System;

namespace XUnit_testing_assignment
{
    class Food
    {
        public Position FoodPosition { get; private set; }
        public Food()
        {
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {
            throw new NotImplementedException("No method for setting postion of food");
        }
    }
}