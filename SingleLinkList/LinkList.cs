using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkList
{
	class LinkList<T> : Interface.IListDS<T>
	{
		private Node<T> head;

		internal Node<T> Head
		{
			get
			{
				return head;
			}

			set
			{
				head = value;
			}
		}

		public LinkList()
		{
			head = null;
		}

		void Interface.IListDS<T>.Append(T i_item)
		{
			var appendItem = new Node<T>(i_item);
			var position = new Node<T>();

			if(head == null)
			{
				head = appendItem;
				return;
			}

			position = head;

			while(position.Next != null)
			{
				position = position.Next;
			}

			position.Next = appendItem;
		}

		void Interface.IListDS<T>.Clear()
		{
			head = null;
		}

		T Interface.IListDS<T>.Delete(int i_Index)
		{
			if(this.InternalIsEmpty() || i_Index < 0)
			{
				Console.WriteLine("Link is empty or position is error!");
				return default(T);
			}

			var deleteItem = new Node<T>();

			if (i_Index == 1)
			{
				deleteItem = head;
				head = head.Next;
				return deleteItem.Data;
			}

			int tempIndex = 1;
			var position = head;
			var preDeleteItem = new Node<T>();

			while(tempIndex < i_Index && position.Next != null)
			{				
				++tempIndex;
				preDeleteItem = position;
				position = position.Next;
			}

			if(tempIndex == i_Index)
			{
				preDeleteItem.Next = position.Next;
				return position.Data;
			}
			else
			{
				Console.WriteLine("The ithem node is not exist!");
				return default(T);
			}
		}

		T Interface.IListDS<T>.GetElement(int i_Index)
		{
			if (this.InternalIsEmpty() || i_Index < 0)
			{
				Console.WriteLine("Link is empty or position is error!");
				return default(T);
			}

			int tempIndex = 1;
			var position = head;
			var preGetItem = new Node<T>();

			while (tempIndex < i_Index && position.Next != null)
			{
				++tempIndex;
				preGetItem = position;
				position = position.Next;
			}

			if (tempIndex == i_Index)
			{
				return position.Data;
			}
			else
			{
				Console.WriteLine("The ithem node is not exist!");
				return default(T);
			}
		}

		int Interface.IListDS<T>.GetLength()
		{
			return InternalGetLength();
		}

		void Interface.IListDS<T>.Insert(T i_Item,int i_Index)
		{
			if(i_Index < 1 || this.InternalIsEmpty())
			{
				Console.WriteLine("List is empty or position is error!");
			}

			var insertItem = new Node<T>(i_Item);
			var preItem = new Node<T>();
			var position = head;
			var tempIndex = 1;

			if(i_Index == 1)
			{
				insertItem.Next = position.Next;
				position.Next = insertItem;
				return;
			}

			while(tempIndex < i_Index && position.Next != null)
			{
				preItem = position;
				position = position.Next;
				++tempIndex;
			}

			if(tempIndex == i_Index)
			{
				preItem.Next = insertItem;
				insertItem.Next = position;
			}
			else
			{
				Console.WriteLine("position error!");
				return;
			}
		}

		bool Interface.IListDS<T>.IsEmpty()
		{
			return InternalIsEmpty();
		}

		int Interface.IListDS<T>.Locate(T value)
		{
			var position = head;
			var tempIndex = 1;

			if (this.InternalIsEmpty())
			{
				Console.WriteLine("List is Empty!");
				return -1;
			}

			while(!position.Data.Equals(value) && position.Next != null)
			{
				position = position.Next;
				++tempIndex;
			}

			return tempIndex;
		}

		public void ReversLinkList()
		{
			var position = this.head.Next;
			var node = new Node<T>();
			this.head.Next = null;

			while(position!= null)
			{
				node = position;
				position = position.Next;
				node.Next = this.head.Next;
				this.head.Next = node;
			}
		}

		public static LinkList<String> CreateLinkList()
		{
			var result = new LinkList<String>();
			var input = Console.ReadLine();

			result.Head = new Node<String>();
			var position = result.Head;

			while (input != "qq")
			{
				position.Next = new Node<String>(input);
				position = position.Next;
				input = Console.ReadLine();
			}
			return result;
		}

		public static void PrintLinkList(LinkList<T> i_linkList)
		{
			var position = i_linkList.Head;

			while (position.Next != null)
			{
				if(position.Data == null)
				{
					Console.Write("Head");
				}
				else
				{
					Console.Write("->{0}", position.Data);
				}
				
				position = position.Next;
			}

			if(position != null)
			{
				Console.Write("->{0}", position.Data);
			}
		}

		//----------------------------helper----------------------

		private int InternalGetLength()
		{
			var position = head;

			int length = 0;
			while (position != null)
			{
				++length;
				position = position.Next;
			}

			return length;
		}

		private bool InternalIsEmpty()
		{
			if (head == null || head.Next == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
