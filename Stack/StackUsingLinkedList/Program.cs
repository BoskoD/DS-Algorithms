using System;

namespace StackUsingLinkedList
{
	public class Node
	{
		public int Data { get; set; }
		public Node Next { get; set; }

		public Node(int data)
		{
			Data = data;
			Next = null;
		}
	}

	public class StackUsingLinkedList
	{
		public Node Head { get; set; }
		public int Size { get; set; }

		public void CreateStack()
		{
			Head = null;
			Size = 0;
		}

		public void Push(int data)
		{
			Node newNode = new(data);
			if (Head == null)
			{
				Head = newNode;
			}
			else
			{
				Head.Next = newNode;
				Head = newNode;
			}
			Size++;
		}

		public void Pop()
		{
			if (Head == null)
			{
				Console.WriteLine("Stack Underflow Error!");
			}
			else
			{
				int temp = Head.Data;
				Console.WriteLine(temp);
				Head = Head.Next;
			}
			Size--;
		}

		public bool IsEmpty()
		{
			if (Head == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Peek()
		{
			if (Head == null)
			{
				Console.WriteLine("Empty Stack!");
			}
			else
			{
				int temp = Head.Data;
				Console.WriteLine(temp);
			}
		}

		public void DeleteStack()
		{
			Head = null;
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			StackUsingLinkedList stack = new();

			// create stack
			stack.CreateStack();

			// push elements to the stack
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			// remove and return top element from stack
			stack.Pop();
		}
	}
}