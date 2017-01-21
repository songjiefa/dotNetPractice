using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHuffmanTree
{
	class HuffmanTree<T>
	{
		private Node<T>[] m_data;
		private int m_leafNumber;

		internal Node<T>[] Data
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

		public int LeafNumber
		{
			get
			{
				return m_leafNumber;
			}

			set
			{
				m_leafNumber = value;
			}
		}

		public Node<T> this[int i_index]
		{
			get
			{
				return Data[i_index];
			}
			set
			{
				Data[i_index] = value;
			}
		}

		public HuffmanTree(int i_lefNumber)
		{
			//书上方法有错，换了一种方法实现
			//m_data = new Node<T>[2 * i_lefNumber - 1];
			m_data = new Node<T>[i_lefNumber];
			m_leafNumber = i_lefNumber;
		}

		public void Create()
		{
			for(int i = 0; i < m_data.Count(); i++)
			{
				m_data[i] = new Node<T>();
			}
			for(int i = 0; i < m_leafNumber; i++)
			{
				m_data[i].Weight = Convert.ToInt32(Console.ReadLine().ToString());
			}
			
			//书上的方法好像有错。。。
			//for (int i = 0; i < m_leafNumber - 1; i++)
			//{
			//	int minWeight1= Int32.MaxValue, minWeight2 = Int32.MaxValue;
			//	int recordIndex1=0, recordIndex2 = 0;

			//	for(int j = 0; j < m_leafNumber + i; j++)
			//	{
			//		if(m_data[i].Weight<minWeight1 && m_data[i].Parrent == null)
			//		{
			//			minWeight2 = minWeight1;
			//			recordIndex2 = recordIndex1;
			//			recordIndex1 = j;
			//			minWeight1 = m_data[j].Weight;
			//		}
			//		else if(m_data[i].Weight < minWeight2 && m_data[i].Parrent == null)
			//		{
			//			minWeight2 = m_data[i].Weight;
			//			recordIndex2 = j;
			//		}
			//	}

			//	m_data[recordIndex1].Parrent = m_data[m_leafNumber + i];
			//	m_data[m_leafNumber + i].Weight = m_data[recordIndex1].Weight + m_data[recordIndex2].Weight;
			//	m_data[m_leafNumber + i].LeftChild = m_data[recordIndex1];
			//	m_data[m_leafNumber + i].RightChild = m_data[recordIndex2];
			//}
			var data = m_data.ToList();
			while(data.Count != 1)
			{
				int minWeight = int.MaxValue, recordIndex = 0;
				
				for(int i = 0; i < data.Count(); i++)
				{
					if(data[i].Weight< minWeight)
					{
						minWeight = data[i].Weight;
						recordIndex = i;
					}
				}
				var min1 = data[recordIndex];
				data.RemoveAt(recordIndex);

				minWeight = int.MaxValue;
				recordIndex = 0;
				for (int i = 0; i < data.Count(); i++)
				{
					if (data[i].Weight < minWeight)
					{
						minWeight = data[i].Weight;
						recordIndex = i;
					}
				}
				var min2 = data[recordIndex];
				data.RemoveAt(recordIndex);

				var newNode = new Node<T>();
				min1.Parrent = newNode;
				min2.Parrent = newNode;
				newNode.Weight = min1.Weight + min2.Weight;
				newNode.LeftChild = min1;
				newNode.RightChild = min2;

				data.Add(newNode);
			}

			m_data = data.ToArray();
		}
	}
}
