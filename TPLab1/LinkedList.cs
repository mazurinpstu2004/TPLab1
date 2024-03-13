using System;
using System.Collections.Generic;

namespace TPLab1
{
    public class LinkedList
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }
        Node head = null;
        Node tail = null;
        int count = 0;
        public Node Find(int pos)
        {
            if (pos >= count)
            {
                return null;
            }
            int i = 0;
            int listLength = count;
            if (pos <= listLength / 2)
            {
                Node p = head;
                while (p != null && i < pos)
                {
                    p = p.Next;
                    i++;
                }
                return p;
            }
            else
            {
                Node p = tail;
                while (p != null && i > pos)
                {
                    p = p.Previous;
                    i--;
                }
                return p;
            }
        }
        public void Add(int value)
        {
            Node NewNode = new Node(value);
            if (head == null)
            {
                head = NewNode;
                tail = NewNode;
            }
            else
            {
                tail.Next = NewNode;
                NewNode.Previous = tail;
                tail = NewNode;
            }
            count++;
        }
        public void Insert(int value, int pos)
        {
            if (pos < 0 || pos > count)
            {
                return;
            }
            Node newNode = new Node(value);
            Node prevNode = Find(pos - 1);
            Node nextNode = Find(pos);

            if (pos == 0)
            {
                newNode.Next = head;
                if (head != null)
                {
                    head.Previous = newNode;
                }
                head = newNode;

                if (tail == null)
                {
                    tail = newNode;
                }
            }
            else
            {
                if (prevNode == null || prevNode == tail)
                {
                    return;
                }
                prevNode.Next = newNode;
                newNode.Previous = prevNode;
                newNode.Next = nextNode;
                if (nextNode != null)
                {
                    nextNode.Previous = newNode;
                }
                else
                {
                    tail = newNode;
                }
            }
        }
        public void Delete(int pos)
        {
            if (pos < 0 || pos >= count)
            {
                return;
            }
            Node PrevNode = Find(pos - 1);
            Node NextNode = Find(pos + 1);

            if (PrevNode != null)
            {
                PrevNode.Next = NextNode;
            }
            else
            {
                head = NextNode;
            }
            if (NextNode != null)
            {
                NextNode.Previous = PrevNode;
            }
            else
            {
                tail = PrevNode;
            }
        }
        public void Clear()
        {
            count = 0;
            head = null;
            tail = null;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= count)
                {
                    return 0;
                }
                Node CurNode = Find(i);
                return CurNode.Data;
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    return;
                }
                Node CurNode = Find(i);
                if (CurNode == null)
                {
                    return;
                }
                else
                {
                    CurNode.Data = value;
                }
            }
        }
        public void Print()
        {
            Node CurNode = head;
            while (CurNode != null)
            {
                Console.Write("{0} ", CurNode.Data);
                CurNode = CurNode.Next;
            }
            Console.WriteLine();
        }
    }
}
