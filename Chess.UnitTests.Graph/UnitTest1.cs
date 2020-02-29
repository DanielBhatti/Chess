using NUnit.Framework;
using Chess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.UnitTests.Graph
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerticesAreUnique()
        {
            bool passed = true;
            List<Vertex> vertices = new List<Vertex>() { };

            for(int i = 0; i < 1000; i++)
            {
                Random random = new Random();
                int x = random.Next(0, 1000);
                int y = random.Next(0, 1000);
                Tile tile = new Tile(x, y);
                Vertex vertex = new Vertex(tile);
                vertices.Add(vertex);
            }

            foreach(Vertex vertex in vertices.ToList())
            {
                if(vertices.Where(v => vertex.Equals(v)).Count() != 1)
                {
                    passed = false;
                    break;
                }
            }

            Assert.IsTrue(passed);
        }
    }
}