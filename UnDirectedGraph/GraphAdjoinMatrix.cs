using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDirectedGraph
{
	class GraphAdjoinMatrix<T> : IGraph<T>
	{
		private GraphNode<T>[] m_nodes;
		private int[,] m_matrix;
		private int m_edgesNumber;

		internal GraphNode<T>[] Nodes
		{
			get
			{
				return m_nodes;
			}

			set
			{
				m_nodes = value;
			}
		}

		public int[,] Matrix
		{
			get
			{
				return m_matrix;
			}

			set
			{
				m_matrix = value;
			}
		}

		public int EdgesNumber
		{
			get
			{
				return m_edgesNumber;
			}

			private set
			{
				m_edgesNumber = value;
			}
		}

		public GraphAdjoinMatrix(int n)
		{
			m_nodes = new GraphNode<T>[n];
			m_matrix = new int[n, n];
			m_edgesNumber = 0;
		}

		public GraphNode<T> GetGraphNode(int i_index)
		{
			if (i_index < GetNumberOfVertex())
			{
				return m_nodes[i_index];
			}
			else
			{
				Console.WriteLine(string.Format("does not exist node[{0}]", i_index));
				return null;
			}
		}

		public void SetGraphNode(GraphNode<T> i_node, int i_index)
		{
			if (i_index < GetNumberOfVertex())
			{
				m_nodes[i_index] = i_node;
			}
			else
			{
				Console.WriteLine(string.Format("does not exist node[{0}]", i_index));
			}
		}

		public int GetNumberofEdge()
		{
			return m_edgesNumber;
		}

		public int GetNumberOfVertex()
		{
			return m_nodes.Count();
		}

		public void SetEdge(GraphNode<T> i_node1, GraphNode<T> i_node2)
		{
			if (IsNode(i_node1) && IsNode(i_node2))
			{
				m_matrix[GetIndexByNode(i_node1), GetIndexByNode(i_node2)] = 1;
				m_matrix[GetIndexByNode(i_node2), GetIndexByNode(i_node1)] = 1;
				m_edgesNumber++;
			}
			else
			{
				Console.WriteLine("does not exist node1 or node2");
			}
		}

		public void DeleteEdge(GraphNode<T> i_node1, GraphNode<T> i_node2)
		{
			if (IsNode(i_node1) && IsNode(i_node2))
			{
				if (m_matrix[GetIndexByNode(i_node1), GetIndexByNode(i_node2)] == 1)
				{
					m_matrix[GetIndexByNode(i_node1), GetIndexByNode(i_node2)] = 0;
					m_matrix[GetIndexByNode(i_node2), GetIndexByNode(i_node1)] = 0;
					m_edgesNumber--;
				}
			}
			else
			{
				Console.WriteLine("does not exist node1 or node2");
			}
		}

		public bool IsEdge(GraphNode<T> i_node1, GraphNode<T> i_node2)
		{
			if (IsNode(i_node1) && IsNode(i_node2))
			{
				return m_matrix[GetIndexByNode(i_node1), GetIndexByNode(i_node2)] == 1;
			}
			else
			{
				Console.WriteLine("does not exist node1 or node2");
				return false;
			}
		}

		public bool IsNode(GraphNode<T> i_node)
		{
			return m_nodes.Contains(i_node);
		}

		public void PrintSelf()
		{
			for (int y = 0; y < m_matrix.GetLength(1);y++)
			{
				for(int x = 0; x < m_matrix.GetLength(0); x++)
				{
					Console.Write(m_matrix[x, y] + " ");
				}
				Console.WriteLine();
			}
		}

		private int GetIndexByNode(GraphNode<T> i_node)
		{
			for (int index = 0; index < m_nodes.Count(); index++)
			{
				if (m_nodes[index].Equals(i_node))
				{
					return index;
				}
			}

			Console.WriteLine(String.Format("does not exist node"));
			return -1;
		}

		
	}
}
