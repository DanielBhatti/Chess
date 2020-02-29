using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IPiece
    {
        string Id { get; }
        Color Color { get; }
        Enum Status { get; }
    }
}
