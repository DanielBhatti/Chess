using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Chessboard
{
    public class VerticalMovement : Movement
    {
        public bool IsTop { get; private set; }
        public bool IsBottom { get; private set; }

        public VerticalMovement(bool isTop = false, bool isBottom = false)
        {
            IsBottom = isBottom;
            IsTop = isTop;
        }

        public void SetVerticalMovement(bool isTop = false, bool isBottom = false)
        {
            IsBottom = isBottom;
            IsTop = isTop;
        }
    }
}
