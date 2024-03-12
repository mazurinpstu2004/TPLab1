using System;

namespace TPLab1
{
    public class ArrayList
    {
        int[] buf = null;
        int count = 0;
        void Expand()
        {
            if (buf == null)
            {
                buf = new int[1];
                return;
            }
            if (buf.Length != count)
            {
                return;
            }
            int[] temp = new int[buf.Length * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i] = buf[i];
            }
            buf = temp;
        }
        public void Add(int value)
        {
            Expand();
            buf[count] = value;
            count++;
        }
        public void Insert(int value, int pos)
        {
            if (pos < 0 || pos > count)
            {
                return;
            }
            Expand();
            for (int i = count; i > pos; i--)
            {
                buf[i] = buf[i - 1];
            }
            buf[pos] = value;
            count++;
        }
        public void Delete(int pos)
        {
            if (pos < 0 || pos >= count)
            {
                return;
            }
            for (int i = pos; i < count - 1; i++)
            {
                buf[i] = buf[i + 1];
            }
            count--;
        }
        public void Clear()
        {
            count = 0;
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
                return buf[i];
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    return;
                }
                buf[i] = value;
            }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", buf[i]);
            }
            Console.WriteLine();
        }
    }
}