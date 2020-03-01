using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Movement : IMovement
    {
        public List<Vertex> GetConnectedVertices(Graph graph, Vertex vertex)
        {
            List<Vertex> connectedVertices = new List<Vertex>() { };
            List<Edge> edges = graph.GetEdgesContainingVertex(vertex);
            foreach (Edge edge in edges)
            {
                if (edge.Movement.GetType() == this.GetType())
                {
                    if (!edge.StartVertex.Equals(vertex)) connectedVertices.Add(vertex);
                    else if (!edge.EndVertex.Equals(vertex)) connectedVertices.Add(vertex);
                }
            }
            return connectedVertices;
        }

        public List<Vertex> GetBeginningVertices(Graph graph, Vertex vertex)
        {
            List<Vertex> connectedVertices = new List<Vertex>() { };
            List<Edge> edges = graph.GetEdgesContainingVertex(vertex);
            foreach (Edge edge in edges)
            {
                if (edge.Movement.GetType() == this.GetType())
                {
                    if (!edge.StartVertex.Equals(vertex)) connectedVertices.Add(vertex);
                    else if (!edge.EndVertex.Equals(vertex)) connectedVertices.Add(vertex);
                }
            }
            return connectedVertices;
        }

        public List<Vertex> GetEndingVertices(Graph graph, Vertex vertex)
        {
            List<Vertex> connectedVertices = new List<Vertex>() { };
            List<Edge> edges = graph.GetEdgesContainingVertex(vertex);
            foreach (Edge edge in edges)
            {
                if (edge.Movement.GetType() == this.GetType())
                {
                    if (!edge.StartVertex.Equals(vertex)) connectedVertices.Add(vertex);
                    else if (!edge.EndVertex.Equals(vertex)) connectedVertices.Add(vertex);
                }
            }
            return connectedVertices;
        }
    }
}
