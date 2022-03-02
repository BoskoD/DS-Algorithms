using System;

namespace BinaryTreeUsingArray
{
	public class BinaryTreeUsingArray
	{
		int[] array;
		int lastUsedIndex;

		public void CreateBinaryTree(int size)
		{
			array = new int[size + 1];
			lastUsedIndex = 0;
			Console.WriteLine("Binary tree has been created!");
		}

		bool IsTreeFull()
		{
			if (array.Length - 1 == lastUsedIndex)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		void Insert(int value)
		{
			if (IsTreeFull())
			{
				Console.WriteLine("Tree is full!");
				return;
			}

			array[lastUsedIndex + 1] = value;
			lastUsedIndex++;
			Console.WriteLine("Value = " + value + " inserted!");
		}

		// Linear search on the array 
		public int Search(int value)
		{
			for (int i = 1; i <= lastUsedIndex; i++)
			{
				if (array[i] == value)
				{
					Console.WriteLine("Found " + value + " at index " + i);
					return i;
				}
			}
			Console.WriteLine(value + " does not exist!");
			return -1;
		}

		public void DeleteNode(int value)
		{
			int location = Search(value);

			//If Value does not exists in Array
			if (location == -1)
			{
				return;
			}
			else
			{
				//insert last element of the Tree into current location
				array[location] = array[lastUsedIndex];
				lastUsedIndex--;
				Console.WriteLine("Successfully deleted " + value + " from the Tree!");
			}
		}

		public void DeleteBinaryTree()
		{
			try
			{
				array = null;
				Console.WriteLine("Tree has been deleted successfully!");
			}
			catch (Exception e)
			{
				Console.WriteLine("There was an error deleting the tree.");
			}
		}

		/*
			Tree Traversal Algorithms:
			1. Pre-order traversal (DFS)
			2. In-order traversal (DFS)
			3. Post-order traversal (DFS)
			4. Level order Traversal (BFS)
		*/

		public void PreOrder(int index)
		{
			if (index > lastUsedIndex)
			{
				return;
			}

			Console.WriteLine(array[index]);
			PreOrder(index * 2);
			PreOrder(index * 2 + 1);
		}

		void PostOrder(int index)
		{
			if (index > lastUsedIndex)
			{
				return;
			}
			PostOrder(index * 2);
			PostOrder(index * 2 + 1);
			Console.WriteLine(array[index]);
		}

		void InOrder(int index)
		{
			if (index > lastUsedIndex)
			{
				return;
			}
			InOrder(index * 2);
			Console.WriteLine(array[index]);
			InOrder(index * 2 + 1);
		}

		public void LevelOrder()
		{
			for (int i = 1; i <= lastUsedIndex; i++)
			{
				Console.WriteLine(array[i]);
			}
		}

		internal class Program
		{
			static void Main(string[] args)
			{
				BinaryTreeUsingArray binary_tree = new();
				binary_tree.CreateBinaryTree(7);

				binary_tree.Insert(10);
				binary_tree.Insert(20);
				binary_tree.Insert(30);
				binary_tree.Insert(40);
				binary_tree.Insert(50);
				binary_tree.Insert(60);
				binary_tree.Insert(70);

				Console.WriteLine("\nPreOrder - DFS\n");
				binary_tree.PreOrder(1);

				Console.WriteLine("\nInOrder - DFS\n");
				binary_tree.InOrder(1);

				Console.WriteLine("\nInOrder - DFS\n");
				binary_tree.PostOrder(1);

				Console.WriteLine("\nLevelOrder - DFS\n");
				binary_tree.LevelOrder();
			}
		}
	}
}