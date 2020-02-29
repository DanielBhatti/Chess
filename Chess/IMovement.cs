using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IMovement
    {
        Enum MovementType { get; set; }

        List<ITile> Movements(ITile iTile);
    }
}
