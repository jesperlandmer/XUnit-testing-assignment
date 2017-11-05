using System;

namespace XUnit_testing_assignment
{
    class Position
    {
        private int _x;
        private int _y;
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
                throw new NotImplementedException("XCoordinate not implemented");
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
                throw new NotImplementedException("XCoordinate not implemented");
            }
        }
    }
}