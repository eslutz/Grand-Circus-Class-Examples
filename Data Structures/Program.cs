using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures
{
	class Program
	{
		static void Main(string[] args)
		{
			//stacks on stacks on stacks
			int sum = 0;
			Stack<int> st = new Stack<int>();
			st.Push(10);
			st.Push(20);
			st.Push(50);
			st.Push(15);
			int next = (int)st.Pop();
			Console.WriteLine(next);
			Console.WriteLine(st.Count);
			sum += next;
			st.Push(25);
			Console.WriteLine(st.Pop());
			Console.WriteLine(st.Count);
			Console.WriteLine(st.Peek());
			Console.WriteLine();

			//queueing forever
			Queue<string> myQ = new Queue<string>();
			myQ.Enqueue("Hello");
			myQ.Enqueue("There");
			myQ.Enqueue("Everybody");
			myQ.Dequeue();
			myQ.Enqueue("World");
			while(myQ.Count > 0)
			{
				Console.WriteLine(myQ.Dequeue());
			}
		}
	}
}