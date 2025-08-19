namespace Orion.Helpers.LinkedList
{
    public class LRUCache
    {
        public Dictionary<string, DoublyLinkedListNode> cache = new Dictionary<string, DoublyLinkedListNode>();
        public int maxSize;
        public int currentSize;
        public DoublyLinkedList listOfMostRecent = new DoublyLinkedList();

        public LRUCache(int maxSize)
        {
            this.maxSize = maxSize > 1 ? maxSize : 1;
        }

        // O(1) time | O(1) space
        public void InsertKeyValuePair(string key, int value)
        {
            if (!cache.ContainsKey(key))
            {
                if (currentSize == maxSize)
                {
                    EvictLeastRecent();
                }
                else
                {
                    currentSize++;
                }

                cache[key] = new DoublyLinkedListNode(key, value);
            }
            else
            {
                ReplaceKey(key, value);
            }

            UpdateMostRecent(cache[key]);
        }

        // O(1) time | O(1) space
        public LRUResult GetValueFromKey(string key)
        {
            if (!cache.ContainsKey(key))
            {
                return new LRUResult(false, -1);
            }

            UpdateMostRecent(cache[key]);
            return new LRUResult(true, cache[key].value);
        }

        // O(1) time | O(1) space
        public string GetMostRecentKey()
        {
            return listOfMostRecent.head.key;
        }

        private void EvictLeastRecent()
        {
            string keyToRemove = listOfMostRecent.tail.key;
            listOfMostRecent.RemoveTail();
            cache.Remove(keyToRemove);
        }

        private void UpdateMostRecent(DoublyLinkedListNode node)
        {
            listOfMostRecent.SetHeadTo(node);
        }

        private void ReplaceKey(string key, int value)
        {
            if (!cache.ContainsKey(key))
            {
                return;
            }

            cache[key].value = value;
        }
    }

    public class LRUResult
    {
        public bool found;
        public int value;

        public LRUResult(bool found, int value)
        {
            this.found = found;
            this.value = value;
        }
    }

    public class DoublyLinkedListNode
    {
        public string key;
        public int value;
        public DoublyLinkedListNode prev;
        public DoublyLinkedListNode next;

        public DoublyLinkedListNode(string key, int value)
        {
            this.key = key;
            this.value = value;
        }

        public void RemoveBindings()
        {
            if (prev != null)
            {
                prev.next = next;
            }

            if (next != null)
            {
                next.prev = prev;
            }

            prev = null;
            next = null;
        }
    }

    public class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public void SetHeadTo(DoublyLinkedListNode node)
        {
            if (head == node)
            {
            }
            else if (head == null)
            {
                head = node;
                tail = node;
            }
            else if (head == tail)
            {
                tail.prev = node;
                head = node;
                head.next = tail;
            }
            else
            {
                if (tail == node)
                {
                    RemoveTail();
                }

                node.RemoveBindings();
                head.prev = node;
                node.next = head;
                head = node;
            }
        }

        public void RemoveTail()
        {
            if (tail == null) return;

            if (tail == head)
            {
                head = null;
                tail = null;
                return;
            }

            tail = tail.prev;
            if (tail != null) tail.next = null;
        }
    }
}
