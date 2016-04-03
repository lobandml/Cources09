using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09.MyDictionary
{
    class DictionaryElement<TKey, TValue>
    {
        public TKey Key { get; private set; }
        public TValue Value { get;private set; }
        public DictionaryElement<TKey, TValue> Next{get;set;}

        
        public DictionaryElement(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
            this.Next = null;
        }
        
    }
}
