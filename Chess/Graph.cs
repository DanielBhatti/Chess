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
            if (VertexSet.Contains(edge.BeginningVertex) && VertexSet.Contains(edge.EndingVertex)) EdgeSet.Add(edge);
            else throw new ArgumentException("Could not find one or both of the specified vertices in the edge set.");
        }

        public void AddEdge(Vertex beginningVertex, Vertex endingVertex, IMovement iMovement)
        {
            if (VertexSet.Contains(beginningVertex) && VertexSet.Contains(endingVertex))
            {
                Edge edge = new Edge(beginningVertex, endingVertex, iMovement);
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

        public List<Edge> GetEdgesContainingVertex(Vertex vertex)
        {
            List<Edge> edgesContainingVertex = new List<Edge>() { };
            foreach(Edge edge in EdgeSet)
            {
                if(edge.BeginningVertex.Equals(vertex) || edge.EndingVertex.Equals(vertex))
                {
                    edgesContainingVertex.Add(edge);
                }
            }
            return edgesContainingVertex;
        }
    }

    public class Vertex
    {
        public string Id { get; }
        public ITile Tile { get; }

        public Vertex(ITile iTile)
        {
            Id = $"{iTile.Id}: ({iTile.X}, {iTile.Y})";
            Tile = iTile;
        }

        public Vertex(string id)
        {
            Id = id;
        }

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
        public Vertex BeginningVertex { get; }
        public Vertex EndingVertex { get; }
        public IMovement Movement { get; }

        public Edge(Vertex beginningVertex, Vertex endingVertex, IMovement iMovement)
        {
            BeginningVertex = beginningVertex;
            EndingVertex = endingVertex;
            Movement = iMovement;
        }

        public override string ToString()
        {
            return $"Edge: {BeginningVertex}, {EndingVertex}";
        }

        public bool Equals(Edge edge)
        {
            if (edge.BeginningVertex.Equals(this.BeginningVertex) && edge.EndingVertex.Equals(this.EndingVertex)) return true;
            else return false;
        }
    }
}
