using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
	public class Node<T>
	{
		private T m_data;
		private Node<T> m_leftChild;
		private Node<T> m_rightChild;
		private Node<T> m_parent;

		public T Data
		{
			get
			{
				return m_data;
			}

			set
			{
				m_data = value;
			}
		}

		public Node<T> LeftChild
		{
			get
			{
				return m_leftChild;
			}

			set
			{
				m_leftChild = value;
			}
		}

		public Node<T> RightChild
		{
			get
			{
				return m_rightChild;
			}

			set
			{
				m_rightChild = value;
			}
		}

		public Node<T> Parent
		{
			get
			{
				return m_parent;
			}

			set
			{
				m_parent = value;
			}
		}

		public Node(T i_data, Node<T> i_leftChild, Node<T> i_rightChild, Node<T> i_parent)
		{
			Data = i_data;
			LeftChild = i_leftChild;
			RightChild = i_rightChild;
			Parent = i_parent;
		}

		public Node(Node<T> i_leftChild, Node<T> i_rightChild, Node<T> i_parent)
		{
			Data = default(T);
			LeftChild = i_leftChild;
			RightChild = i_rightChild;
			Parent = i_parent;
		}

		public Node(T i_data)
		{
			Data = i_data;
			LeftChild = null;
			RightChild = null;
			Parent = null;
		}

		public Node()
		{
			Data = default(T);
			LeftChild = null;
			RightChild = null;
			Parent = null;
		}
	}
}
