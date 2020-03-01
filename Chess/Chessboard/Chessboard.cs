using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Chessboard
{
    public class Chessboard : IBoard
    {
        public string Id { get; }

        public Graph Graph { get; }

        public Chessboard()
        {
            Id = "Chessboard";
            Graph = new Graph();

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Vertex vertex = new Vertex(i, j);
                    Graph.AddVertex(vertex);
                }
            }

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Vertex startVertex = Graph.GetVertexByPosition(i, j);
                    Vertex endVertex;
                    if(i != 0 && j != 0 && i!= 7 && j != 7)
                    {
                        endVertex = Graph.GetVertexByPosition(i + 1, j);
                        Edge rightEdge = new Edge(startVertex, endVertex, new HorizontalMovement(isRight: true));

                        endVertex = Graph.GetVertexByPosition(i - 1, j);
                        Edge leftEdge = new Edge(startVertex, endVertex, new HorizontalMovement(isLeft: true));

                        endVertex = Graph.GetVertexByPosition(i, j + 1);
                        Edge topEdge = new Edge(startVertex, endVertex, new VerticalMovement(isTop: true));

                        endVertex = Graph.GetVertexByPosition(i, j - 1);
                        Edge bottomEdge = new Edge(startVertex, endVertex, new VerticalMovement(isBottom: true));

                        endVertex = Graph.GetVertexByPosition(i + 1, j + 1);
                        Edge topRightEdge = new Edge(startVertex, endVertex, new DiagonalMovement(isTopRight: true));

                        endVertex = Graph.GetVertexByPosition(i + 1, j - 1);
                        Edge bottomRightEdge = new Edge(startVertex, endVertex, new DiagonalMovement(isBottomRight: true));

                        endVertex = Graph.GetVertexByPosition(i - 1, j + 1);
                        Edge topLeftEdge = new Edge(startVertex, endVertex, new DiagonalMovement(isTopLeft: true));

                        endVertex = Graph.GetVertexByPosition(i - 1, j - 1);
                        Edge bottomLeftEdge = new Edge(startVertex, endVertex, new DiagonalMovement(isBottomLeft: true));

                        Graph.AddEdge(rightEdge);
                        Graph.AddEdge(leftEdge);
                        Graph.AddEdge(topEdge);
                        Graph.AddEdge(bottomEdge);
                        Graph.AddEdge(topRightEdge);
                        Graph.AddEdge(bottomRightEdge);
                        Graph.AddEdge(topLeftEdge);
                        Graph.AddEdge(bottomLeftEdge);
                    }
                    else
                    {
                        if (i != 7)
                        {
                            endVertex = Graph.GetVertexByPosition(i + 1, j);
                            Edge rightEdge = new Edge(startVertex, endVertex, new HorizontalMovement(isRight: true));
                            Graph.AddEdge(rightEdge);
                        }
                        if (i != 0)
                        {
                            endVertex = Graph.GetVertexByPosition(i - 1, j);
                            Edge leftEdge = new Edge(startVertex, endVertex, new HorizontalMovement(isLeft: true));
                            Graph.AddEdge(leftEdge);
                        }
                        if (j != 7)
                        {
                            endVertex = Graph.GetVertexByPosition(i, j + 1);
                            Edge topEdge = new Edge(startVertex, endVertex, new VerticalMovement(isTop: true));
                            Graph.AddEdge(topEdge);
                        }
                        if (j != 0)
                        {
                            endVertex = Graph.GetVertexByPosition(i, j - 1);
                            Edge bottomEdge = new Edge(startVertex, endVertex, new VerticalMovement(isBottom: true));
                            Graph.AddEdge(bottomEdge);
                        }
                    }
                }
            }
        }

        public void CapturePiece(IPiece iPiece)
        {
            throw new NotImplementedException();
        }

        public Color CurrentPlayer()
        {
            throw new NotImplementedException();
        }

        public int CurrentTurn()
        {
            throw new NotImplementedException();
        }

        public List<ITile> GetPossibleMoves(IPiece iPiece)
        {
            throw new NotImplementedException();
        }

        public void InitializeBoard()
        {
            throw new NotImplementedException();
        }

        public bool IsCheckmateState()
        {
            throw new NotImplementedException();
        }

        public bool IsCheckState()
        {
            throw new NotImplementedException();
        }

        public void LoadBoard()
        {
            throw new NotImplementedException();
        }

        public void MovePiece(IPiece iPiece)
        {
            throw new NotImplementedException();
        }

        public int NumberOfPlayerPieces(Color color)
        {
            throw new NotImplementedException();
        }

        public int NumberOfTiles()
        {
            throw new NotImplementedException();
        }

        public void RedoMove()
        {
            throw new NotImplementedException();
        }

        public void ResetBoard()
        {
            throw new NotImplementedException();
        }

        public void SaveBoard()
        {
            throw new NotImplementedException();
        }

        public void UndoMove()
        {
            throw new NotImplementedException();
        }
    }
}
