using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IBoard
    {
        void ResetBoard();

        void UndoMove();

        void SaveBoard();

        void LoadBoard();

        bool IsCheckState();

        bool IsCheckMateState();

        int NumberOfWhitePieces();

        int NumberOfBlackPieces();

        int NumberOfTiles();
    }
}
