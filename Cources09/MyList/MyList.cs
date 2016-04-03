using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09
{
    class MyList <T>
    {
        private ListElement<T> head;
        public int Length{get;private set;}

        

        
        public MyList()
        {
            Length = 0;
            head = null;
        }

        public void Add(T value)
        {
            if (head != null)
            {
                ListElement<T> iterator = head;
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = new ListElement<T>(value);
            }
            else
            {
                head = new ListElement<T>(value);
            }
            Length++;
        }
        private T GetElementValue(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }

            ListElement<T> listIterator = this.head;

            for (int i = 0; i < index; i++)
            {
                listIterator = listIterator.Next;
            }
            
                return listIterator.Element;
        }
        private ListElement<T> GetListElement(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }
            ListElement<T> listIterator = this.head;
            for (int i = 0; i < index; i++)
            {
                listIterator = listIterator.Next;
            }

            return listIterator;
        }

        


        
        public T this[int index]
        {
            get
            {
                return GetElementValue(index);
            }
            set
            {
                GetListElement(index).Element = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0;i<Length;i++)
            {
                yield return GetElementValue(i);
            }
        }
        

    }
}
