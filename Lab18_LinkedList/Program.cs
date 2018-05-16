using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddToEnd("Danny");
            list.AddToEnd("Jaide");

            list.PrintAllNodes();

            object o = new object();

            list.RemoveAll(o);



			int[] ArrayOne = new int[] { 1, 2, 3, 4, 5, 5, 5, 5 };

			int Count1 = 0;
			int Count2 = 0;
			int Count3 = 0;
			int Count4 = 0;
			int Count5 = 0;
			int Count6 = 0;
			int Count7 = 0;
			int Count8 = 0;
			int Count9 = 0;

            
                foreach (var item in ArrayOne)
                {
                    if (item == 1)
                    {
                        Count1++;
                    }
                    else if (item == 2)
                    {
                        Count2++;
                    }
                    else if (item == 3)
                    {
                        Count3++;
                    }
                    else if (item == 4)
                    {
                        Count4++;
                    }
                    else if (item == 5)
                    {
                        Count5++;
                    }
                    else if (item == 6)
                    {
                        Count6++;
                    }
                    else if (item == 7)
                    {
                        Count7++;
                    }
                    else if (item == 8)
                    {
                        Count8++;
                    }
                    else if (item == 9)
                    {
                        Count9++;
                    }
                    else
                    {
                        Console.WriteLine("What?");
                    }
                }

                Console.WriteLine(Count1);
                Console.WriteLine(Count2);
                Console.WriteLine(Count3);
                Console.WriteLine(Count4);
                Console.WriteLine(Count5);
                Console.WriteLine(Count6);
                Console.WriteLine(Count7);
                Console.WriteLine(Count8);
                Console.WriteLine(Count9);
        }
    }
}