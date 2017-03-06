using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class Graph
    {
        private IList<Vertex> _vertices;

        public Graph(IList<Vertex> vertices)
        {
            _vertices = vertices;
        }

        public void AddEdge(Vertex source, Vertex destination, int weight = 0)
        {
            source.AdjecentVertices.Add(new Edge(source, destination, weight));
        }

        public IList<Vertex> V 
        { 
            get 
            { 
                return _vertices; 
            } 
        }

        public IList<Edge> E
        {
            get
            {
                return _vertices
                    .SelectMany(v => v.AdjecentVertices)
                    .ToList();
            }
        }

        public IEnumerable<Vertex> GetAdjecentVertices(Vertex v)
        {
            return v.AdjecentVertices.Select(ed => ed.Destination);
        }
    }
}