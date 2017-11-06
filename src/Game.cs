using System;

namespace XUnit_testing_assignment.src
{
    class Game
    {
        public enum Controls
        {
            Right,
            Left,
            Up,
            Down
        }
        public Snake Snake { get; private set; }
        
        public Game()
        {
            throw new NotImplementedException();
        }

        public void PrintGameBoard()
        {
            throw new NotImplementedException();
        }

        public void FeedSnake()
        {
            throw new NotImplementedException();
        }

        public void SetDirection(Controls dir)
        {
            throw new NotImplementedException();
        }

        public bool IsSnakeFed()
        {
            throw new NotImplementedException();
        }
    }
}