using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IMovement
    {
        List<Vertex> GetConnectedVertices(Graph graph, Vertex vertex);
    }
}
