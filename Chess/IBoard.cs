using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IBoard
    {
        string Id { get; set; }
        ITile[] Tiles { get; set; }

        void MovePiece();

        void CapturePiece();

        void InitializeBoard();

        void ResetBoard();

        void UndoMove();

        void RedoMove();

        void SaveBoard();

        void LoadBoard();

        bool IsCheckState();

        bool IsCheckmateState();

        int NumberOfPlayerPieces(Color color);

        int NumberOfTiles();

        int CurrentTurn();

        Color CurrentPlayer();

        List<ITile> GetPossibleMoves(IPiece iPiece);
    }
}
