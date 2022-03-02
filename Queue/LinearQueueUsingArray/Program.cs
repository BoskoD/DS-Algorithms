using System;

namespace LinearQueueUsingArray
{
	public class LinearQueueUsingArray
	{
		int[] arr;
		int back;
		int front;

		public void CreateQueue(int size)
		{
			arr = new int[size];
			back = -1;
			front = -1;
		}

		public void EnQueue(int value)
		{
			// if the queue is full
			if (arr.Length - 1 == back)
			{
				Console.WriteLine("Queue Overflow Error!");
			}
			else if (back == -1)
			{ // if the queue is empty
				front = 0;
				back++;
				arr[back] = value;
			}
			else
			{ // if the queue already has some elements
				back++;
				arr[back] = value;
			}
		}

		public void DeQueue()
		{
			if (back == -1)
			{
				Console.WriteLine("Queue Underflow Error.");
			}
			else
			{
				int tmp = arr[front];
				Console.WriteLine(tmp);
				arr[front] = 0;
				front++;
				if (front > back)
				{
					front = back = -1;
				}
			}
		}

		public void Peek()
		{
			if (front != -1)
			{
				Console.WriteLine(arr[front]);
			}
			else
			{
				Console.WriteLine("Queue is empty!");
			}
		}

		public bool IsEmpty()
		{
			if (front == -1)
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
			if (back == arr.Length - 1)
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
			arr = null;
		}

		public void PrintQueue()
		{
			if (front == -1)
			{
				Console.WriteLine("Queue is empty!");
			}
			else
			{
				for (int i = front; i <= back; i++)
				{
					Console.WriteLine(arr[i]);
				}
			}
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			LinearQueueUsingArray queue = new();

			queue.CreateQueue(5);

			queue.EnQueue(1);
			queue.EnQueue(2);
			queue.EnQueue(3);
			queue.EnQueue(4);
			queue.EnQueue(5);

			// queue = [1, 2, 3, 4, 5]

			queue.Peek(); // output: 1

			Console.WriteLine(queue.IsEmpty()); // output: false

			Console.WriteLine(queue.IsFull()); // output: true

			queue.DeQueue(); // output: 1
							 // queue after deQueue() operation, queue = [0, 2, 3, 4, 5]

			Console.WriteLine("... Queue ...");
			queue.PrintQueue(); // output: 2, 3, 4, 5
		}
	}
}