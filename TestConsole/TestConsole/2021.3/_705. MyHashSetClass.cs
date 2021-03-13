using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class MyHashSet
    {
        List<int> baseData = new List<int>();
        /** Initialize your data structure here. */
        public MyHashSet()
        {

        }

        public void Add(int key)
        {
            if (!baseData.Contains(key))
            {
                baseData.Add(key);
            }
        }

        public void Remove(int key)
        {
            baseData.Remove(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return baseData.Contains(key);
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
