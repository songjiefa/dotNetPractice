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
			/*
					1
			2				3
		4		5		6		7
			 */
			BinaryTree<int> bTree = new BinaryTree<int>(1);
			var leftChild = bTree.InsertToLeftChild(2, bTree.GetRoot());
			var rightChild = bTree.InsertToRightChild(3, bTree.GetRoot());

			bTree.InsertToLeftChild(4, leftChild);
			bTree.InsertToRightChild(5, leftChild);
			bTree.InsertToLeftChild(6, rightChild);
			bTree.InsertToRightChild(7, rightChild);

			LevelOrder(bTree.GetRoot());
			Console.ReadKey();
		}

		public static void PreOrderDLR(Node<int> i_node)
		{
			if(i_node == null)
			{
				return;
			}

			Console.WriteLine("{0}", i_node.Data);

			PreOrderDLR(i_node.LeftChild);
			PreOrderDLR(i_node.RightChild);
		}

		public static void PreOrderLDR(Node<int> i_node)
		{
			if (i_node == null)
			{
				return;
			}

			PreOrderLDR(i_node.LeftChild);
			Console.WriteLine("{0}", i_node.Data);
			PreOrderLDR(i_node.RightChild);
		}

		public static void PreOrderLRD(Node<int> i_node)
		{
			if (i_node == null)
			{
				return;
			}

			PreOrderLRD(i_node.LeftChild);
			PreOrderLRD(i_node.RightChild);
			Console.WriteLine("{0}", i_node.Data);
		}

		public static void LevelOrder(Node<int> i_root)
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
