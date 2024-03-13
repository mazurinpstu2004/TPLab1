using System;
using System.Security.Claims;

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

            int check = 1;

            if (linkList.Count == aList.Count && linkList.Count == chList.Count && aList.Count == chList.Count)
            {
                for (int i = 0; i < aList.Count; i++)
                {
                    if (linkList[i] != aList[i] && linkList[i] != chList[i] && aList[i] != chList[i])
                    {
                        Console.WriteLine("Найдена ошибка");
                        check = 0;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Найдена ошибка");
                check = 0;
            }
            if (check == 1)
            {
                Console.WriteLine("Ошибок нет");
            }
        }
    }
    }