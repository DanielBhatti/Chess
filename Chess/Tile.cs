using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Tile : ITile
    {
        public string Id { get; }
        public int X { get; }
        public int Y { get; }
        public IPiece Piece { get; private set; }

        public Tile(int x, int y)
        {
            Id = this.GetHashCode().ToString();
            X = x;
            Y = y;
        }

        public List<ITile> GetAdjacentTiles(IBoard iBoard)
        {
            return new List<ITile>() { };
        }

        public bool HasPiece()
        {
            if (Piece == null) return false;
            else return true;
        }

        public void AddPiece(IPiece iPiece)
        {
            Piece = iPiece;
        }

        public void RemovePiece()
        {
            Piece = null;
        }
    }
}
