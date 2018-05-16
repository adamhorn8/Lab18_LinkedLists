using System;
namespace Lab18_LinkedList
{
    public class Algorithm
    {

		private Node head;
        private Node current;//This will have latest node
        public int Count;
        int data;

		public Algorithm()
        {
            head = null;
            current = null;
            Count = 0;
        }

		int[] ArrayOne = new int[] { 1, 2, 3, 4, 5, 5, 5, 5 };

		int Count1;
		int Count2;
		int Count3;
		int Count4;
		int Count5;
		int Count6;
		int Count7;
		int Count8;
		int Count9;

        public void AlgorithmOne()
		{
            foreach (var item in ArrayOne)
			{
				if (item == 1)
				{
					Count1++;
				}
				else if (item ==2)
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
