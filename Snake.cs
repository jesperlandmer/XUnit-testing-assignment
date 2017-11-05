using System;
using System.Collections.Generic;

namespace XUnit_testing_assignment
{
    class Snake
    {
        private int _length;
        private Position _headPosition;
        public List<Position> Positions { get; private set; }

        public Snake()
        {
            throw new NotImplementedException("No Constructor Implemented");
        }

        public void Set(int length, Position headPosition)
        {
            throw new NotImplementedException("No Set Method Implemented");
        }
        public void SetBodyPositions()
        {
            throw new NotImplementedException("No Set Method for Body Positions Implemented");
        }
        public void GrowSnake()
        {
            throw new NotImplementedException("No Snake-Growing Method Implemented");
        }

        public int Length
        {
            get
            {
                return _length;
            }
            private set
            {
                throw new NotImplementedException("No Length Implemented");
            }
        }

        public Position HeadPosition
        {
            get
            {
                return _headPosition;
            }
            private set
            {
                throw new NotImplementedException("No HeadPosition Implemented");
            }
        }
    }
}