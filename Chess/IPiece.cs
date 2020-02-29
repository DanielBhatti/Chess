using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IPiece
    {
        string Id { get; set; }
        Color Color { get; set; }
        Enum Status { get; set; }
    }
}
