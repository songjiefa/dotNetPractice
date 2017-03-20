using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDirectedGraph
{
	interface IGraph<T>
	{
		int GetNumberOfVertex();

		int GetNumberofEdge();

		void SetEdge(GraphNode<T> i_index1, GraphNode<T> i_index2);

		void DeleteEdge(GraphNode<T> i_index1, GraphNode<T> i_index2);

		bool IsEdge(GraphNode<T> i_index1, GraphNode<T> i_index2);
	}
}
