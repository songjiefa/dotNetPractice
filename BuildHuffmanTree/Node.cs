using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHuffmanTree
{
	class Node<T>
	{
		private T m_data;
		private int m_weight;
		private Node<T> m_leftChild;
		private Node<T> m_rightChild;
		private Node<T> m_parrent;

		public int Weight
		{
			get
			{
				return m_weight;
			}

			set
			{
				m_weight = value;
			}
		}

		internal Node<T> LeftChild
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

		internal Node<T> RightChild
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

		internal Node<T> Parrent
		{
			get
			{
				return m_parrent;
			}

			set
			{
				m_parrent = value;
			}
		}

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

		public Node()
		{
			m_data = default(T);
			m_weight = -1;
			m_leftChild = null;
			m_rightChild = null;
			m_parrent = null;
		}

		public Node(T i_data)
		{
			m_data = i_data;
			m_weight = -1;
			m_leftChild = null;
			m_rightChild = null;
			m_parrent = null;
		}

		public Node(T i_data, int i_weight, Node<T> i_leftChild, Node<T> i_rightChild, Node<T> i_parent)
		{
			m_data = i_data;
			m_weight = i_weight;
			m_leftChild = i_leftChild;
			m_rightChild = i_rightChild;
			m_parrent = i_parent;
		}
	}
}
