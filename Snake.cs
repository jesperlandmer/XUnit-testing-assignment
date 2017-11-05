using System;
using System.Collections.Generic;

namespace XUnit_testing_assignment
{
    class Snake
    {
        const int INITIAL_LENGTH = 5;
        const int INITIAL_XCOORDINATE = 10;
        const int INITIAL_YCOORDINATE = 10;

        private int _length;
        public Position HeadPosition  { get; private set; }
        public List<Position> Positions { get; private set; }

        public Snake()
        {
            Length = INITIAL_LENGTH;
            HeadPosition = new Position(INITIAL_XCOORDINATE, INITIAL_YCOORDINATE);
            Positions = new List<Position>();

            Positions.Add(HeadPosition);
            SetBodyPositions();
        }

        public void Set(int length, Position headPosition)
        {
            Length = length;
            HeadPosition = headPosition;
        }
        public void SetBodyPositions()
        {
            int x = HeadPosition.XCoordinate - 1;
            int y = HeadPosition.YCoordinate - 1;

            for (int i = 0; i < Length; i++)
            {
                Positions.Add(new Position(x, y));
                x -= 1;
                y -= 1;
            }
        }
        public void GrowSnake()
        {
            Length += 1;
        }

        public int Length
        {
            get
            {
                return _length;
            }
            private set
            {
                if (value < INITIAL_LENGTH)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _length = value;
            }
        }
    }
}