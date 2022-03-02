using System;

namespace LinearQueueUsingLinkedList
{
	public class LinearQueueUsingLinkedList
	{
		private class Node
		{
			public int Value { get; set; }
			public Node Next { get; set; }

			public Node(int value)
			{
				Value = value;
				Next = null;
			}
		}

		Node front;
		Node back;

		public void CreateQueue()
		{
			front = back = null;
		}

		public void EnQueue(int value)
		{
			Node newNode = new(value);
			if (front == null)
			{
				front = back = newNode;
			}
			else
			{
				back.Next = newNode;
				back = newNode;
			}
			Console.WriteLine("Inserted " + value);
		}

		public void DeQueue()
		{
			if (front == null)
			{
				Console.WriteLine("Queue is Empty!");
			}
			else
			{
				int tmp = front.Value;
				front = front.Next;
				Console.WriteLine("Deleted " + tmp);
				if (front == null)
				{
					back = null;
				}
			}
		}

		public void Peek()
		{
			if (front == null)
			{
				Console.WriteLine("Queue is Empty!");
			}
			else
			{
				Console.WriteLine("Peek " + front.Value);
			}
		}

		public bool IsEmpty()
		{
			if (front == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void DeleteQueue()
		{
			front = back = null;
			Console.WriteLine("Queue is Deleted!");
		}

		public void PrintQueue()
		{
			Node current = front;
			while (current != null)
			{
				Console.WriteLine(current.Value);
				current = current.Next;
			}
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			LinearQueueUsingLinkedList queue = new();

			queue.CreateQueue();

			queue.EnQueue(10);
			queue.EnQueue(20);
			queue.EnQueue(30);
			queue.EnQueue(40);
			queue.EnQueue(50);

			queue.PrintQueue();

			queue.DeQueue();
			queue.DeQueue();

			queue.PrintQueue();

			queue.Peek();

			Console.WriteLine(queue.IsEmpty());

			queue.DeleteQueue();

			queue.PrintQueue();
		}
	}
}