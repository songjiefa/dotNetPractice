using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace TestConsole
{
	class Program
	{

		static List<String> list = new List<String>();
		static void Main(string[] args)
		{
			using (FileStream fsRead = new FileStream(@"C:\Users\71473\Desktop\1.txt", FileMode.Open))
			{
				int fsLen = (int)fsRead.Length;
				byte[] heByte = new byte[fsLen];
				fsRead.Seek(2, SeekOrigin.Begin);
				int r = fsRead.Read(heByte, 2, 3);
				string myStr = System.Text.Encoding.UTF8.GetString(heByte);
				Console.WriteLine(myStr);
				Console.ReadKey();
			}
			Console.ReadKey();
		}

		private static int[] Init(int n)
		{
			var nums = new int[n];
			for (var i = 0; i < n; i++)
			{
				nums[i] = i + 1;
			}

			return nums;
		}

		private static bool CanPrint(int[] nums)
		{
			for (var i = 0; i < nums.Length - 1; i++)
			{
				for (var j = i+1; j < nums.Length; j++)
				{
					if (nums[i] == nums[j] || nums[i] == 0 || nums[j] == 0)
						return false;
				}
			}
			return true;
		}

		private static void Print(int[] nums)
		{
			for (var i = 0; i < nums.Length; i++)
			{
				Console.Write(nums[i]);
			}
			Console.WriteLine();
		}

		private static bool IsEnd(int[] nums)
		{
			for (var i = 0; i < nums.Length; i++)
				if (nums[i] < nums.Length) return false;

			return true;
		}

		private static int GetTotal(int[] nums)
		{
			var total = 0;
			for (var i = 0; i < nums.Length; i++) total += nums[i];

			return total;
		}

		public static void QuickSort(ref int[] i_arrs, int i_left, int i_right)
		{
			var l = i_left + 1;
			var r = i_right;

			while (l != r)
			{
				while (i_arrs[r] >= i_arrs[i_left] && r > l)r--;

				while (i_arrs[l] <= i_arrs[i_left] && l < r)l++;

				if (l != r)
				{
					var left = i_arrs[l];
					i_arrs[l] = i_arrs[r];
					i_arrs[r] = left;
				}
			}

			var le = i_arrs[l];
			i_arrs[l] = i_arrs[i_left];
			i_arrs[i_left] = le;

			if (l - 1 > i_left)
			{
				QuickSort(ref i_arrs, i_left, l - 1);
			}

			if (r + 1 < i_right)
			{
				QuickSort(ref i_arrs, r + 1, i_right);
			}
		}

		public static void BubbleSort(ref int[] i_arrs)
		{
			for(var i = 0; i < i_arrs.Length - 1; i++)
			{
				for(var j = i + 1; j < i_arrs.Length; j++)
				{
					if (i_arrs[j] < i_arrs[i])
					{
						var tmp = i_arrs[j];
						i_arrs[j] = i_arrs[i];
						i_arrs[i] = tmp;
					}
				}
			}
		}

		public static bool IsLargeNew(string sourceStr, string compareStr)
		{
			for (int i = 0; i < sourceStr.Length; i++)
			{
				if (sourceStr[i] > compareStr[i])
				{
					return true;
				}
				else if (sourceStr[i] == compareStr[i])
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			return false;
		}

		public static bool IsLarge(string sourceStr,string compareStr)
		{
			var shourtLen = sourceStr.Length < compareStr.Length ? sourceStr.Length : compareStr.Length;

			for (int i = 0; i < shourtLen; i++)
			{
				if(sourceStr[i] > compareStr[i])
				{
					return true;
				}
				else if(sourceStr[i] == compareStr[i])
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			if (sourceStr.Length < compareStr.Length)
			{
				var s = 0;

				while(sourceStr[s] == compareStr[shourtLen] && s < shourtLen -1)
				{
					s++;
				}

				return sourceStr[s] > compareStr[shourtLen];
			}
			else if (sourceStr.Length > compareStr.Length)
			{
				var s = 0;

				while (sourceStr[shourtLen] == compareStr[s] && s < shourtLen - 1)
				{
					s++;
				}
				return sourceStr[shourtLen] > compareStr[s];
			}
			else
			{
				return false;
			}
		}


		public static int QueryCount()
		{
			
			int i = 0;
			try
			{
				return i;
			}
			finally
			{
				i = 10;
			}
		}
	}
}


