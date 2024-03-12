using System;

namespace TPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();
            ChainList chList = new ChainList();
            LinkedList linkList = new LinkedList();

            Random r = new Random();
            for (int i = 0; i < 5000; i++)
            {
                int pos = r.Next(100);
                int value = r.Next(100);
                int operation = r.Next(5);
                switch (operation)
                {
                    case 0:
                        aList.Add(value);
                        chList.Add(value);
                        linkList.Add(value);
                        break;
                    case 1:
                        aList.Insert(value, pos);
                        chList.Insert(value, pos);
                        linkList.Insert(value, pos);
                        break;
                    case 2:
                        aList.Delete(pos);
                        chList.Delete(pos);
                        linkList.Delete(pos);
                        break;
                    case 3:
                        aList.Clear();
                        chList.Clear();
                        linkList.Clear();
                        break;
                    case 4:
                        aList[pos] = value;
                        chList[pos] = value;
                        linkList[pos] = value;
                        break;
                }
            }
            aList.Print();
            Console.WriteLine("*******************************");
            chList.Print();
            Console.WriteLine("*******************************");
            linkList.Print();

        }
    }
}