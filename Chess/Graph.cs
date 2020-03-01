using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    public class Graph
    {
        public List<Vertex> VertexSet { get; }
        public List<Edge> EdgeSet { get; }

        public Graph(List<Vertex> vertexSet, List<Edge> edgeSet)
        {
            VertexSet = vertexSet;
            EdgeSet = edgeSet;
        }

        public Graph()
        {
            VertexSet = new List<Vertex>() { };
            EdgeSet = new List<Edge>() { };
        }

        public void AddVertex(Vertex vertex)
        {
            foreach(Vertex v in VertexSet)
            {
                if (v.Equals(vertex)) throw new ArgumentException("Vertices must have unique ids.");
            }
            VertexSet.Add(vertex);
        }

        public void AddVertex(IEnumerable<Vertex> vertices)
        {
            foreach(Vertex vertex in vertices)
            {
                AddVertex(vertex);
            }
        }

        public void AddEdge(Edge edge)
        {
            if (VertexSet.Contains(edge.StartVertex) && VertexSet.Contains(edge.EndVertex)) EdgeSet.Add(edge);
            else throw new ArgumentException("Could not find one or both of the specified vertices in the edge set.");
        }

        public void AddEdge(Vertex beginningVertex, Vertex endingVertex, Movement movement)
        {
            if (VertexSet.Contains(beginningVertex) && VertexSet.Contains(endingVertex))
            {
                Edge edge = new Edge(beginningVertex, endingVertex, movement);
                EdgeSet.Add(edge);
            }
            else throw new ArgumentException("Could not find one or both of the specified vertices in the edge set.");
        }

        public void AddEdge(IEnumerable<Edge> edges)
        {
            foreach(Edge edge in edges)
            {
                AddEdge(edge);
            }
        }

        public Vertex GetVertexByPosition(int x, int y)
        {
            foreach(Vertex vertex in VertexSet)
            {
                if (vertex.X == x && vertex.Y == y) return vertex;
            }
            return null;
        }

        public List<Edge> GetEdgesContainingVertex(Vertex vertex)
        {
            List<Edge> edgesContainingVertex = new List<Edge>() { };
            foreach(Edge edge in EdgeSet)
            {
                if(edge.StartVertex.Equals(vertex) || edge.EndVertex.Equals(vertex))
                {
                    edgesContainingVertex.Add(edge);
                }
            }
            return edgesContainingVertex;
        }
    }

    public class Vertex : Tile
    {
        public Vertex(int x, int y) : base(x, y) { }

        public override string ToString()
        {
            return $"Vertex: {Id}";
        }

        public bool Equals(Vertex vertex)
        {
            if (vertex.Id == this.Id) return true;
            else return false;
        }
    }

    public class Edge
    {
        public Vertex StartVertex { get; }
        public Vertex EndVertex { get; }
        public Movement Movement { get; }

        public Edge(Vertex startVertex, Vertex endVertex, Movement movement)
        {
            StartVertex = startVertex;
            EndVertex = endVertex;
            Movement = movement;
        }

        public override string ToString()
        {
            return $"Edge: {StartVertex}, {EndVertex}";
        }

        public bool Equals(Edge edge)
        {
            if (edge.StartVertex.Equals(this.StartVertex) && edge.EndVertex.Equals(this.EndVertex)) return true;
            else return false;
        }
    }
}
