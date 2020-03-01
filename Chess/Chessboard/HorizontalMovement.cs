using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Chessboard
{
    public class HorizontalMovement : Movement
    {
        public bool IsRight { get; private set; }
        public bool IsLeft { get; private set; }

        public HorizontalMovement(bool isRight = false, bool isLeft = false)
        {
            IsRight = isRight;
            IsLeft = isLeft;
        }

        public void SetHorizontalMovement(bool isRight = false, bool isLeft = false)
        {
            IsLeft = isLeft;
            IsRight = isRight;
        }
    }
}
