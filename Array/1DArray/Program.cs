using System;

namespace _1DArray
{
	class Program
	{
		public static int Get(int[] nums, int index)
		{
			return nums[index];
		} // TC: O(1)

		public static void Insert(int[] nums, int index, int val)
		{
			nums[index] = val;
		} // TC: O(1)

		public static void Update(int[] nums, int index, int val)
		{
			nums[index] = val;
		} // TC: O(1)

		public static void Delete(int[] nums, int index)
		{
			nums[index] = 0;
		} // TC: O

		public static void Traversal(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine(nums[i]);
			}
		}

		public static int BinarySearch(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;
			while (left <= right)
			{
				var mid = (left + right) / 2;
				if (nums[mid] == target)
				{
					return mid;
				}
				else if (target > nums[mid])
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}
			return -1;
		} // TC: O(Log2n)


		static void Main(string[] args)
		{
			int[] nums1 = { 1, 2, 3, 4, 5, 6 };
			Get(nums1, 0); // it will return, 1

			int[] nums2 = new int[4]; // {0,0,0,0}
			Insert(nums2, 0, 1); // {1,0,0,0}
			Insert(nums2, 1, 2); // {1,2,0,0}
			Insert(nums2, 2, 3); // {1,2,3,0}
			Insert(nums2, 3, 4); // {1,2,3,4}

			int[] nums3 = { 1, 2, 3 };
			Update(nums3, 0, 4); // {4,2,3}
			Update(nums3, 1, 5); // {4,5,3}
			Update(nums3, 2, 6); // {4,5,6}

			Traversal(nums3);
			Console.WriteLine($"Number 5 is at position: {BinarySearch(nums3, 5)}"); //1

			int[] nums4 = { 1, 2, 3 };
			Delete(nums4, 0); // {0,1,2}
			Delete(nums4, 1); // {0,0,2}
			Delete(nums4, 2); // {0,0,0}
		}
	}
}