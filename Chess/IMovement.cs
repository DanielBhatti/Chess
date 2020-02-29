using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IMovement
    {
        List<ITile> Movements(ITile iTile);
    }
}
