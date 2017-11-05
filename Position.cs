using System;

namespace XUnit_testing_assignment
{
    class Position
    {
        private int _x;
        private int _y;

        public Position()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }
        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        public int XCoordinate
        {
            get
            {
                return _x;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _x = value;
            }
        }
        public int YCoordinate
        {
            get
            {
                return _y;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _y = value;
            }
        }
    }
}