using System;

namespace XUnit_testing_assignment
{
    class Food
    {
        private Random _random = new Random();
        public Position FoodPosition { get; private set; }
        public Food()
        {
            FoodPosition = GetRandomPosition();
        }

        public Position GetRandomPosition()
        {
            int x = _random.Next(1, 20);
            int y = _random.Next(1, 20);

            return new Position(x,y);
        }
    }
}