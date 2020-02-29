using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface ITile
    {
        string Id { get; }

        int X { get; }
        int Y { get; }

        IPiece Piece { get; }

        bool HasPiece();

        void AddPiece(IPiece iPiece);

        void RemovePiece();

        List<ITile> GetAdjacentTiles(IBoard iBoard);
    }
}
