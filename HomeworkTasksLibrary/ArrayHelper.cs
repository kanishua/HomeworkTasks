using System;

namespace HomeworkTasksLibrary
{
    public class ArrayHelper
    {
        public static int[] GanerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
                if (random.Next(0, 3) == 0)
                {
                    array[i] = 0;
                }
            }

            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //+1.Find the minimum element of an array.
        public static int FindMinElement(int[] array)
        {
            return array[FindIndexMinElement(array)];
        }

        //+2.Find the maximum element of an array.
        public static int FindMaxElement(int[] array)
        {
            return array[FindIndexMaxElement(array)];
        }

        //+3.Find the index of the minimum element of the array.
        public static int FindIndexMinElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array");
            }

            int indexMinElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[indexMinElement])
                {
                    indexMinElement = i;
                }
            }

            return indexMinElement;
        }

        //+4.Find the index of the maximum element of the array.
        public static int FindIndexMaxElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array");
            }

            int indexMaxElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indexMaxElement])
                {
                    indexMaxElement = i;
                }
            }

            return indexMaxElement;
        }

        //+5.Calculate the sum of array elements with odd indices.
        public static int CountSumElementsWithOddIndex(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        //+6.Make an array reverse (an array in the opposite direction)
        public static void MakeReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0; i < (array.Length / 2); i++)
            {
                Swap(ref array[i], ref array[(array.Length - 1) - i]);
            }
        }

        //+7.Count the number of odd array elements.
        public static int CountNumberOddElements(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            int numberOddElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numberOddElements += 1;
                }
            }

            return numberOddElements;
        }

        /*+8.Swap the first and second half of the array, for example,
        for an array of 1 2 3 4,the result is 3 4 1 2,
        or for 1 2 3 4 5 -> 4 5 3 1 2.*/
        public static void SwapPlaceHalfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0; i < (array.Length / 2); i++)
            {
                if (array.Length % 2 == 0)
                {
                    Swap(ref array[i], ref array[((array.Length / 2) + i)]);
                }
                else
                {
                    Swap(ref array[i], ref array[((array.Length / 2) + 1) + i]);
                }
            }
        }

        /*+9.Sort the array in ascending order in one of the ways:
        bubble (Bubble), selection (Select) or inserts (Insert))*/
        public static void SortArrayByBubble(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - 1) - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /*10.Sort the array in descending order in one of the ways
        (different from the method in the 9th task):
        bubble (Bubble), selection (Select) or inserts (Insert))*/
        public static void SortArrayByInsert(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            int j;
            int x;
            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                x = array[i];
                while (j > 0 && (x > array[j - 1]))
                {
                    Swap(ref array[j], ref array[j - 1]);
                    j -= 1;
                }
                array[j] = x;
            }
        }
    }
}
