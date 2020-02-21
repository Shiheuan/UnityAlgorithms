using System.Collections.Generic;

namespace Algorithms.Search
{
    public interface ISymbolTable<TKey, TValue>
    {
        void put(TKey key, TValue val);
        TValue get(TKey key);
        void delete(TKey key);
        bool contains(TKey key);
        bool isEmpty();
        int size();
        IEnumerable<TKey> keys();
        TKey min();
        TKey max();
        TKey floor(TKey key);
        TKey ceiling(TKey key);

        int rank(TKey key);
        TKey select(int k);
        void deleteMin();
        void deleteMax();
        int size(TKey lo, TKey hi);
        IEnumerable<TKey> keys(TKey lo, TKey hi);
    }
}

