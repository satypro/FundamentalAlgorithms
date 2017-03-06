namespace Graphs
{
    public class Edge
    {
        private readonly Vertex _source;
        private readonly Vertex _destination;
        private readonly int _weight;

        public Edge(Vertex source, Vertex destination, int weight)
        {
            _source = source;
            _destination = destination;
            _weight = weight;
        }

        public int Weight 
        { 
            get 
            { 
                return _weight; 
            } 
        }
        
        public Vertex Source 
        {
            get
            {
                return _source;
            }
        }

        public Vertex Destination 
        { 
            get 
            { 
                return _destination; 
            } 
        }
    }
}
