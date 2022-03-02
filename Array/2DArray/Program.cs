using System;

namespace _2DArray
{
	class Program
	{
		public static int Get(int[,] nums, int rIndex, int cIndex)
		{
			return nums[rIndex, cIndex];
		} // TC: O(1)

		public static void Insert(int[,] nums, int rIndex, int cIndex, int val)
		{
			nums[rIndex, cIndex] = val;
		} // TC: O(1)

		public static void Update(int[,] nums, int rIndex, int cIndex, int val)
		{
			nums[rIndex, cIndex] = val;
		} // TC: O(1)

		public static void Delete(int[,] nums, int rIndex, int cIndex)
		{
			nums[rIndex, cIndex] = 0;
		} // TC: O(1)

		private static void Traversal(int[,] nums)
		{
			int uBound0 = nums.GetUpperBound(0);
			int uBound1 = nums.GetUpperBound(1);
			for (int i = 0; i <= uBound0; i++)
			{
				for (int j = 0; j <= uBound1; j++)
				{
					int res = nums[i, j];
					Console.WriteLine(res);
				}
			}
		}

		static void Main(string[] args)
		{
			int[,] nums1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			Get(nums1, 0, 0); // it will return, 1
			Get(nums1, 1, 1); // it will return 4

			int[,] nums2 = new int[3, 2]; // {{0,0}, {0,0}, {0,0}}
			Insert(nums2, 0, 0, 1); // {{1,0}, {0,0}, {0,0}}
			Insert(nums2, 0, 1, 2); // {{1,2}, {0,0}, {0,0}}
			Insert(nums2, 1, 0, 3); // {{1,2}, {3,0}, {0,0}}
			Insert(nums2, 1, 1, 4); // {{1,2}, {3,4}, {0,0}}
			Insert(nums2, 2, 0, 5); // {{1,2}, {3,4}, {5,0}}
			Insert(nums2, 2, 1, 6); // {{1,2}, {3,4}, {5,6}}

			int[,] nums3 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			Update(nums3, 0, 0, 7); // {{7,2}, {3,4}, {5,6}}
			Update(nums3, 1, 1, 8); // {{7,2}, {3,8}, {5,6}};
			Update(nums3, 2, 0, 9); // {{7,2}, {3,8}, {9,6}};

			Traversal(nums3);

			int[,] nums4 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			Delete(nums4, 0, 0); // {{0,2}, {3,4}, {5,6}};
			Delete(nums4, 0, 1); // {{0,0}, {3,4}, {5,6}}
			Delete(nums4, 1, 0); // {{0,0}, {0,4}, {5,6}}
			Delete(nums4, 1, 1); // {{0,0}, {0,0}, {5,6}}
			Delete(nums4, 2, 0); // {{0,0}, {0,0}, {0,6}}
			Delete(nums4, 2, 1); // {{0,0}, {0,0}, {0,0}
		}
	}
}