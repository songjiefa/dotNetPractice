using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
	class BinaryTree<T>
	{
		private Node<T> m_head;

		public Node<T> Head
		{
			get
			{
				return m_head;
			}

			set
			{
				m_head = value;
			}
		}

		public BinaryTree(T i_data)
		{
			m_head = new Node<T>(i_data);
		}

		public BinaryTree(T i_data, Node<T> i_leftChild, Node<T> i_rightChild, Node<T> i_parent)
		{
			m_head = new Node<T>(i_data, i_leftChild, i_rightChild, i_parent);
		}

		public bool IsEmpty()
		{
			return m_head == null;
		}

		public Node<T> GetRoot()
		{
			return m_head;
		}

		public Node<T> GetLeftChild(Node<T> i_node)
		{
			return i_node.LeftChild;
		}

		public Node<T> GetRightChild(Node<T> i_node)
		{
			return i_node.RightChild;
		}

		public Node<T> GetParent(Node<T> i_node)
		{
			return i_node.Parent;
		}

		public Node<T> InsertToLeftChild(T i_data, Node<T> i_node)
		{
			var insertNode = new Node<T>(i_data);
			insertNode.LeftChild = i_node.LeftChild;
			insertNode.Parent = i_node;
			i_node.LeftChild = insertNode;

			return insertNode;
		}

		public Node<T> InsertToRightChild(T i_data,Node<T> i_node)
		{
			var insertNode = new Node<T>(i_data);
			insertNode.RightChild = i_node.RightChild;
			insertNode.Parent = i_node;
			i_node.RightChild = insertNode;

			return insertNode;
		}

		public Node<T> DeleteLeftChild(Node<T> i_node)
		{
			if(i_node == null || i_node.LeftChild == null)
			{
				return null;
			}

			var deleteNode = i_node.LeftChild;
			i_node.LeftChild = null;
			return deleteNode;
		}
		public Node<T> DeleteRightChild(Node<T> i_node)
		{
			if (i_node == null || i_node.RightChild == null)
			{
				return null;
			}

			var deleteNode = i_node.RightChild;
			i_node.RightChild = null;
			return deleteNode;
		}

		public bool IsLeafNode(Node<T> i_node)
		{
			return i_node != null && i_node.Parent != null;
		}
	}
}
