using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDirectedGraph
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 9;
			GraphAdjoinMatrix<int> g = new GraphAdjoinMatrix<int>(n);

			GraphNode<int>[] nodes = new GraphNode<int>[n];

			for(int i=0;i<n;i++)
			{
				nodes[i] = new GraphNode<int>(i);
			}

			g.Nodes = nodes;

			

			g.SetEdge(nodes[2], nodes[6]);

			Console.WriteLine(g.GetNumberofEdge());

			g.DeleteEdge(nodes[2], nodes[6]);

			Console.WriteLine(g.GetNumberofEdge());

			g.PrintSelf();

			Console.ReadKey();

		}

		
	}
}
