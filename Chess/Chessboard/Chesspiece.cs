using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Chessboard
{
    public class Chesspiece : Piece
    {
        public PieceName PieceName { get; private set; }

        public Chesspiece(string id, Color color, PieceStatus status, PieceName pieceName) : base(id, color, status)
        {
            PieceName = pieceName;
        }
    }
}
