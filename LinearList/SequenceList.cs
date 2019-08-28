using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList
{
    class SequenceList<T> : IListDS<T>
    {
        private T[] m_data = new T[4];
        private int m_maxSize;
        private int lastIndex;

        public T this[int index]
        {
            get { return m_data[index]; }
            set { m_data[index] = value; }
        }

        public SequenceList()
        {

        }
        public void Add(T i_item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T GetItem(int i_index)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public T Insert(T i_item, int i_index)
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public int Location(T i_item)
        {
            throw new NotImplementedException();
        }

        public T Remove(int i_index)
        {
            throw new NotImplementedException();
        }
    }
}
