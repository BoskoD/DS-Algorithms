using System;

namespace CircularQueueUsingArray
{
	public class CircularQueueUsingArray
	{
		int[] array;
		int front, back;
		int size;

		public void CreateQueue(int len)
		{
			array = new int[len];
			front = -1;
			back = -1;
			size = len;
		}

		public void EnQueue(int value)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is Full.");
			}
			else
			{
				if (front == -1)
					front = 0;
				back = (back + 1) % size;
				array[back] = value;
				Console.WriteLine("Inserted " + value);
			}
		}

		public void DeQueue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is Empty.");
			}
			else
			{
				int tmp = array[front];
				if (front == back)
				{
					front = back = -1;
				}
				else
				{
					front = (front + 1) % size;
				}
				Console.WriteLine(tmp);
			}
		}

		public bool IsEmpty()
		{
			if (back == -1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool IsFull()
		{
			if (front == 0 && back == size - 1)
			{
				return true;
			}
			if (front == back + 1)
			{
				return true;
			}
			return false;
		}

		public void Peek()
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is Empty");
			}
			else
			{
				Console.WriteLine(array[front]);
			}
		}

		public void DeleteQueue()
		{
			array = null;
			front = back = -1;
		}

		public void PrintQueue()
		{
			if (front == -1)
			{
				Console.WriteLine("Queue is Empty!");
				return;
			}

			int i;
			for (i = front; i != back; i = (i + 1) % size)
			{
				Console.WriteLine(array[i]);
			}
			Console.WriteLine("index of front=" + front);
			Console.WriteLine("index of back=" + back);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			CircularQueueUsingArray queue = new();
			queue.CreateQueue(5);

			queue.EnQueue(10);
			queue.EnQueue(20);
			queue.EnQueue(30);
			queue.EnQueue(40);
			queue.EnQueue(50);

			queue.DeQueue();
			queue.DeQueue();
			queue.EnQueue(60);
			queue.PrintQueue();
			queue.DeQueue();
			queue.PrintQueue();
			queue.DeleteQueue();
			queue.PrintQueue();
		}
	}
}