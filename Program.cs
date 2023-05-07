using System;

namespace simpleCode
{ /* Написать метод для поиска индекса элемента массива
     (тип элеметов в массиве int), метод должен вернуть
	 индекс первого найденного элемента(если он будет найден).
	 Предусмотреть, если не будет найдено число.
	 Написать упрощенный метод - IndexOf*/
	internal class Program
	{
		static int IndexOf(int[] arr, int value)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == value)
				{
					Console.WriteLine("элемент массива " + i);
					return i;
				}
			}
			return -1;
		}
		static int[] GetRandomArray(uint length, int minvalue, int maxvalue)
		{
			int[] myArray = new int[length];
			Random random = new Random();
			for (int i = 0; i < myArray.Length; i++)
			{
				myArray[i] = random.Next(minvalue, maxvalue);
			}
			return myArray;
		}

		static void Main(string[] args)
		{

			int[] array = GetRandomArray(10, -1, 10);

			int result = IndexOf(array, 3);
			if (result != -1)
			{
				Console.WriteLine(result);
			} else
			{
                Console.WriteLine("Mo such element in the array");
            }

			//Console.WriteLine("IndexOf " + Array.IndexOf(array, 3));

		}
	}
}
