using System;

namespace StackUsingArray
{
	public class StackUsingArray
	{
		int[] array;
		int topOfStack;

		public void CreateStack(int size)
		{
			array = new int[size];
			topOfStack = -1;
		}

		public void Push(int data)
		{
			if (array.Length - 1 == topOfStack)
			{
				Console.WriteLine("Stack Overflow Error!");
				return;
			}
			else
			{
				array[topOfStack + 1] = data;
				topOfStack++;
				Console.WriteLine("Inserted");
			}
		}

		public void Pop()
		{
			if (topOfStack == -1)
			{
				Console.WriteLine("Stack Underflow Error!");
			}
			else
			{
				var temp = array[topOfStack];
				topOfStack--;
				Console.WriteLine(temp);
			}
		}

		public void Peek()
		{
			if (topOfStack == -1)
			{
				Console.WriteLine("Stack is empty");
			}
			else
			{
				var temp = array[topOfStack];
				Console.WriteLine(temp);
			}
		}

		public bool IsEmpty()
		{
			if (topOfStack == -1)
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
			if (array.Length - 1 == topOfStack)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void DeleteStack()
		{
			array = null;
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Stack! Stack using array implementation");

			StackUsingArray stack = new();

			// create stack of size 5
			stack.CreateStack(2);

			// insert 1 to the stack
			stack.Push(1);
			stack.Push(2);

			// pop from the stack
			stack.Pop();
			stack.Pop();

			// check whether stack is empty or not
			Console.WriteLine(stack.IsEmpty());

			// peek top element from stack
			stack.Peek();

			// isFull method will check whether stack is full or not
			Console.WriteLine(stack.IsFull());
		}
	}
}