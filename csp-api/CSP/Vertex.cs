using System.Collections.Generic;

namespace csp_api.CSP
{
	public class Vertex
	{
		public string Element { get; set; }
		public List<byte> Domain { get; set; }
		public List<Edge> Edges { get; set; }

		public Vertex(string element, List<byte> domain)
		{
			this.Element = element;
			this.Domain = domain;
			Edges = new List<Edge>();
		}

		public void addEdge(Edge edge)
		{
			Edges.Add(edge);
		}
	}
}
