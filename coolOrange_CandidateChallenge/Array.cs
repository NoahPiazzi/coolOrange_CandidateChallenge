using System;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{
		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			int max = array[position1];
			for(int i = position1; i <= position2; i++)
			{
				if (array[i] > max)
					max = array[i];
			}
			return max;
		}
			
		public static int FindMinPosition(int[] array, int position1, int position2)
		{
			int minPos = position1;
			for (int i = position1; i <= position2; i++)
			{
				if (array[i] < array[minPos])
					minPos = i;
			}
			return minPos;
        }

		public static void Swap(int[] array, int position1, int position2)
		{
			int temp = array[position1];
			array[position1] = array[position2];
			array[position2] = temp;
		}

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			if (position1 >= position2)
                return;

			int first = array[position1];
			for(int i= position1; i < position2 - 1; i++)
			{
				array[i] = array[i + 1];
			}
			array[position2 - 1] = first;
		}

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
			Random rand = new Random();
			int[] result = new int[size];
			for (int i = 0; i < size; i++)
			{
				result[i] = rand.Next(minValue, maxValue + 1);
			}
			return result;
		}

		public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
			Random rand = new Random();
			int[,] matrix = new int[rows, columns];
			for(int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					matrix[r, c] = rand.Next(minValue, maxValue + 1);
				}
			}
			return matrix;
		}


		public static int[,] CopyArray(int[] array)
		{
			int[,] result = new int[2, array.Length];
			for(int i = 0; i < array.Length; i++)
			{
				result[0, i] = array[i];
				result[1, i] = array[i];
			}
			return result;
		}

		public static int FindInSortedArray(int[] array, int number)
		{
			int left = 0;
			int right = array.Length - 1;

			while(left <= right)
			{
				int mid = left + (right - left) / 2;

				if (array[mid] == number)
					return mid;

				if (array[mid] < number)
					left = mid + 1;
				else
					right = mid -1;
			}

			return -1;
		}

	}
}
