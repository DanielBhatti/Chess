using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IMovement
    {
        List<Vertex> GetConnectedVertices(Graph graph, Vertex vertex);

        List<Vertex> GetBeginningVertices(Graph graph, Vertex vertex);

        List<Vertex> GetEndingVertices(Graph graph, Vertex vertex);
    }
}
