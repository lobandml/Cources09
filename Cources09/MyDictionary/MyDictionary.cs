using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09.MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        private DictionaryElement<TKey, TValue> head;
        public int Length { get; private set; }

        public MyDictionary()
        {
            Length = 0;
            head = null;
        }
        public void Add(TKey key, TValue value)
        {
            
            if (head != null)
            {
                if (Exist(key)) throw new ArgumentException("Ключ уже находится в словаре");

                DictionaryElement<TKey, TValue> iterator = head;
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = new DictionaryElement<TKey, TValue>(key,value);

            }
            else
            {
                head = new DictionaryElement<TKey, TValue>(key, value);
            }
            Length++;
        }

        public bool Exist(TKey key)
        {
            try
            {
                GetElementByKey(key);
            }
            catch (KeyNotFoundException e)
            {
                return false;
            }
            return true;
        }

        private DictionaryElement<TKey, TValue> GetElementByKey(TKey key)
        {

            DictionaryElement<TKey, TValue> listIterator = this.head;
            
            while (listIterator.Next != null)
            {
                if (key.Equals(listIterator.Key))
                {
                    return listIterator;
                }
                listIterator = listIterator.Next;
            }
            if (key.Equals(listIterator.Key))
            {
                return listIterator;
            }
             throw new KeyNotFoundException();
        }

        private DictionaryElement<TKey, TValue> GetElementByIndex(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }
            DictionaryElement<TKey, TValue> listIterator = this.head;
            for (int i = 0; i < index; i++)
            {
                listIterator = listIterator.Next;
            }

            return listIterator;
        }


        public TValue this[int index]
        {
            get
            {
                return GetElementByIndex(index).Value;
            }
        }

        public IEnumerator<DictionaryElement<TKey,TValue>> GetEnumerator()
        {
            var listIterator = this.head;
            while (listIterator.Next != null)
            {
                yield return listIterator;
                listIterator = listIterator.Next;
            }
            yield return listIterator;
        }

    }
}
