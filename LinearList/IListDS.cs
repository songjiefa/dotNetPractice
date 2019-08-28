using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList
{
    public interface IListDS<T>
    {
        int GetLength();
        void Add(T i_item);
        T Remove(int i_index);
        T Insert(T i_item, int i_index);
        T GetItem(int i_index);

        void Clear();
        bool isEmpty();
        int Location(T i_item);
    }
}
