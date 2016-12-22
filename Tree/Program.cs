using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public void PreOrderDLR(Node<int> i_node)
		{
			if(i_node == null)
			{
				return;
			}

			Console.WriteLine("{0}", i_node.Data);

			PreOrderDLR(i_node.LeftChild);
			PreOrderDLR(i_node.RightChild);
		}

		public void PreOrderLDR(Node<int> i_node)
		{
			if (i_node == null)
			{
				return;
			}

			PreOrderDLR(i_node.LeftChild);
			Console.WriteLine("{0}", i_node.Data);
			PreOrderDLR(i_node.RightChild);
		}

		public void PreOrderLRD(Node<int> i_node)
		{
			if (i_node == null)
			{
				return;
			}

			PreOrderDLR(i_node.LeftChild);			
			PreOrderDLR(i_node.RightChild);
			Console.WriteLine("{0}", i_node.Data);
		}

		public void LevelOrder(Node<int> i_root)
		{
			var queue = new Queue<Node<int>>();

			queue.Enqueue(i_root);

			while(queue.Count > 0)
			{
				var printNode = queue.Dequeue();

				Console.WriteLine("{0}", printNode.Data);

				if(printNode.LeftChild != null)
				{
					queue.Enqueue(printNode.LeftChild);
				}
				if (printNode.RightChild != null)
				{
					queue.Enqueue(printNode.RightChild);
				}
			}
		}
	}


}
