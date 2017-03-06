using System.Collections.Generic;
namespace Graphs
{
    public class Vertex
    {
        public int Color { get; set; }
        public bool Visited { get; set; }
        public IList<Edge> AdjecentVertices { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;

            var o = (Vertex) obj;

            if (o.Color != this.Color)
                return false;

            if (o.Visited != this.Visited)
                return false;

            if (this.AdjecentVertices.Count != o.AdjecentVertices.Count)
                return false;

            for (int i = 0; i < this.AdjecentVertices.Count; i++)
            {
                if (!this.AdjecentVertices[i].Destination.Equals(o.AdjecentVertices[i].Destination))
                    return false;

                if (!this.AdjecentVertices[i].Source.Equals(o.AdjecentVertices[i].Source))
                    return false;

                if (this.AdjecentVertices[i].Weight != o.AdjecentVertices[i].Weight)
                    return false;
            }

            return true;
        }
    }
}
