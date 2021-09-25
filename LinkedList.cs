
using System;

namespace DataStructureAndAlgorithms
{
    public class LinkedList
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }

        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;

            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;

            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }
            size--;
        }

        public int[] ToArray()
        {
            var current = first;
            int index = 0;
            var array = new int[size];
            while (current != null)
            {
                array[index] = current.value;
                current = current.next;
                index++;
            }
            return array;
        }

        public void Reverse()
        {
            // 10 -> 20 -> 30
            var previous = first;
            var current = first.next;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current.next != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public int Size()
        {
            return size;
        }

        private bool IsEmpty()
        {
            return first == null;
        }
    }
}