using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09
{
    class ListElement <T>
    {
        public T Element { get; set;}


        public ListElement<T> Next{ get; set; }

        public ListElement(T element)
        {
            this.Element = element;
            this.Next = null;
        }

    }
}
