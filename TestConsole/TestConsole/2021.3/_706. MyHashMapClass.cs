using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class MyHashMap
    {
        List<int> keyColl = new List<int>();
        List<int> valColl = new List<int>();
        /** Initialize your data structure here. */
        public MyHashMap()
        {
            
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            if (!keyColl.Contains(key))
            {
                keyColl.Add(key);
                valColl.Add(value);
                return;
            }
            int index = keyColl.FindIndex(k => k == key);
            valColl[index] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int index = keyColl.FindIndex(k => k == key);
            if (index == -1)
            {
                return -1;
            }
            return valColl[index];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int index = keyColl.FindIndex(k => k == key);
            if (index == -1)
            {
                return;
            }
            keyColl.RemoveAt(index);
            valColl.RemoveAt(index);
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
}
