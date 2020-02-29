using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Piece : IPiece
    {
        public string Id { get; }
        public Color Color { get; }
        public Enum Status { get; }

        public Piece(string id, Color color, Enum status)
        {
            Id = id;
            Color = color;
            Status = status;
        }
    }
}
