using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Chessboard
{
    public class DiagonalMovement : Movement
    {
        public bool IsTopRight { get; private set; }
        public bool IsTopLeft { get; private set; }
        public bool IsBottomRight { get; private set; }
        public bool IsBottomLeft { get; private set; }

        public DiagonalMovement(bool isTopRight = false, bool isTopLeft = false, bool isBottomRight = false, bool isBottomLeft = false)
        {
            IsTopRight = isTopRight;
            IsTopLeft = isTopLeft;
            IsBottomRight = isBottomRight;
            IsBottomLeft = isBottomLeft;
        }

        public void SetDiagonalMovement(bool isTopRight = false, bool isTopLeft = false, bool isBottomRight = false, bool isBottomLeft = false)
        {
            IsTopRight = isTopRight;
            IsTopLeft = isTopLeft;
            IsBottomRight = isBottomRight;
            IsBottomLeft = isBottomLeft;
        }
    }
}
