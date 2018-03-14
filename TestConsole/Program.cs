using System;


namespace TestConsole
{
	class Program
	{

		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			int[] nums = new int[n];
			var strs = Console.ReadLine().Split(' ');
			//var str1 = "966 820 61 46 396 907 60 163 254 804 275 604 313 269 940 184 378 300 567 189 138 601 51 958 952 287 467 526 198 121 956 315 796 875 851 656 460 506 568 13 130 682 537 382 245 288 593 466 559 176 420 773 566 667 135 349 219 664 949 294 484 772 192 375 399 487 177 219 608 676 48 907 154 791 563 267 578 719 647 107 357 586 195 447 245 426 166 713 57 265 442 455 497 437 940 325 59 25";
			//var strs = str1.Split(' ');
			//BubbleSort(ref strs);
			QuickSort(ref strs, 0, strs.Length - 1);
			foreach (var str in strs)
			{
				Console.Write(str + " ");
			}
			Console.ReadKey();
		}

		public static void QuickSort(ref string[] i_strs, int i_left, int i_right)
		{
			var l = i_left;
			var r = i_right;

			while (l < r)
			{
				l++;
				while (IsLargeNew(i_strs[r] + i_strs[0], i_strs[0] + i_strs[r]) && l < r)
				{
					r--;
				}

				
				while (IsLargeNew(i_strs[0] + i_strs[l], i_strs[l] + i_strs[0]) && l < r)
				{
					l++;
				}

				var left = i_strs[l];
				i_strs[l] = i_strs[r];
				i_strs[r] = left;
			}

			var le = i_strs[l];
			i_strs[l] = i_strs[i_left];
			i_strs[0] = le;

			if(l> i_left)
			{
				QuickSort(ref i_strs, i_left, l);
			}

			if(r < i_right)
			{
				QuickSort(ref i_strs, r, i_right);
			}
		}

		public static void BubbleSort(ref string[] i_strs)
		{
			for(var i = 0; i < i_strs.Length - 1; i++)
			{
				for(var j = i + 1; j < i_strs.Length; j++)
				{
					if (IsLargeNew(i_strs[j] + i_strs[i], i_strs[i] + i_strs[j]))
					{
						var larger = i_strs[j];
						i_strs[j] = i_strs[i];
						i_strs[i] = larger;
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


