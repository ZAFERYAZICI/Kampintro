using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        public class MyDictionary<TKey, TValue>
        {
            Dictionary<TKey, TValue> myDictionary;
            Dictionary<TKey, TValue> tempDictionary;

            public MyDictionary()
            {
                myDictionary = new Dictionary<TKey, TValue>(0);
            }

            public void Add(TKey key, TValue value)
            {
                tempDictionary = myDictionary;
                myDictionary = new Dictionary<TKey, TValue>(myDictionary.Count + 1);

                foreach (var item in tempDictionary)
                {
                    myDictionary.Add(item.Key, item.Value);
                }

                myDictionary.Add(key, value);
            }

            public int Length
            {
                get { return myDictionary.Count; }
            }

            public Dictionary<TKey, TValue> MyDictionaryItems
            {
                get { return myDictionary; }
            }
        }
    }
}
