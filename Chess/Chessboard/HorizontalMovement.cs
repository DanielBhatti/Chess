using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Chessboard
{
    public class HorizontalMovement : IMovement
    {
        public List<Vertex> GetConnectedVertices(Graph graph, Vertex vertex)
        {
            List<Vertex> connectedVertices = new List<Vertex>() { };
            List<Edge> edges = graph.GetEdgesContainingVertex(vertex);
            foreach(Edge edge in edges)
            {
                if (edge.Movement is HorizontalMovement)
                {
                    if (!edge.BeginningVertex.Equals(vertex)) connectedVertices.Add(vertex);
                    else if (!edge.EndingVertex.Equals(vertex)) connectedVertices.Add(vertex);
                }
            }
            return connectedVertices;
        }
    }
}
