using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class LRUCache
    {
        /*
        Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

        get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
        put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

        The cache is initialized with a positive capacity.

        Follow up:
        Could you do both operations in O(1) time complexity?

        Example:

        LRUCache cache = new LRUCache( 2  "capacity"  );

        cache.put(1, 1);
        cache.put(2, 2);
        cache.get(1);       // returns 1
        cache.put(3, 3);    // evicts key 2
        cache.get(2);       // returns -1 (not found)
        cache.put(4, 4);    // evicts key 1
        cache.get(1);       // returns -1 (not found)
        cache.get(3);       // returns 3
        cache.get(4);       // returns 4
        */

        private DLNode head;
        private DLNode tail;
        private int capacity;
        private int numItemsInCache;
        private Dictionary<int, DLNode> keyDict;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            numItemsInCache = 0;
            head = new DLNode();
            tail = new DLNode();
            head.next = tail;
            tail.prev = head;

            keyDict = new Dictionary<int, DLNode>();
        }

        public int Get(int key)
        {
            if (keyDict.ContainsKey(key))
            {
                MoveToHead(keyDict[key]);

                return keyDict[key].val;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (keyDict.ContainsKey(key))
            {
                keyDict[key].val = value;
                MoveToHead(keyDict[key]);
            }
            else
            {
                DLNode node = new DLNode();
                node.val = value;
                node.key = key;
                keyDict.Add(key, node);

                AddToFront(node);
                numItemsInCache++;

                if (numItemsInCache > capacity)
                {
                    RemoveLRU();
                }
            }
        }

        private void AddToFront(DLNode node)
        {
            node.prev = head;
            node.next = head.next;
            head.next.prev = node;
            head.next = node;
        }

        private void RemoveFromList(DLNode node)
        {
            DLNode savedPrev = node.prev;
            DLNode savedNext = node.next;

            savedNext.prev = savedPrev;
            savedPrev.next = savedNext;
        }

        private void MoveToHead(DLNode node)
        {
            RemoveFromList(node);
            AddToFront(node);
        }

        private void RemoveLRU()
        {
            DLNode removed = PopTail();
            keyDict.Remove(removed.key);
            numItemsInCache--;
        }

        private DLNode PopTail()
        {
            DLNode tailToRemove = tail.prev;
            RemoveFromList(tailToRemove);

            return tailToRemove;
        }
    }
}

public class DLNode
{
    public DLNode next;
    public DLNode prev;
    public int val;
    public int key;
}

