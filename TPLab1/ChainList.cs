using System;

namespace TPLab1
{
    public class ChainList
    {
        public class Node
        {
            public int Data { set; get; }
            public Node Next { set; get; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        Node head = null;
        int count = 0;
        public Node Find(int pos)
        {
            if (pos >= count)
            {
                return null;
            }
            int i = 0;
            Node p = head;
            while (p != null && i < pos)
            {
                p = p.Next;
                i++;
            }
            if (i == pos)
            {
                return p;
            }
            else
            {
                return null;
            }
        }
        public void Add(int value)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node lastNode = Find(count - 1);
                lastNode.Next = new Node(value);
            }
            count++;
        }
        public void Insert(int value, int pos)
        {
            if (pos < 0 || pos > count)
            {
                return;
            }
            if (pos != 0)
            {
                Node PrevNode = Find(pos - 1);
                Node NewNode = new Node(value);
                NewNode.Next = PrevNode.Next;
                PrevNode.Next = NewNode;
            }
            else
            {
                Node NewNode = new Node(value);
                NewNode.Next = head;
                head = NewNode;
            }
            count++;
        }
        public void Delete(int pos)
        {
            if (pos < 0 || pos >= count)
            {
                return;
            }
            if (pos != 0)
            {
                Node PrevNode = Find(pos - 1);
                PrevNode.Next = PrevNode.Next.Next;
            }
            else
            {
                head = head.Next;
            }
            count--;
        }
        public void Clear()
        {
            count = 0;
            head = null;
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
                CurNode.Data = value;
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