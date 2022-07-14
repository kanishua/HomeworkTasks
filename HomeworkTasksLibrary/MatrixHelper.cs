using System;

namespace HomeworkTasksLibrary
{
    public class MatrixHelper
    {
        public static int[,] GanerateMatrix(int size1, int size2)
        {
            Random random = new Random();
            int[,] matrix = new int[size1, size2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }

            return matrix;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //+1.Find the minimum element of an array.
        public static int FindMinElement(int[,] matrix)
        {
            (int indexIMinElement, int indexJMinElement) = FindIndexMinElement(matrix);
            return matrix[indexIMinElement, indexJMinElement];
        }

        //+2.Find the maximum element of an array.
        public static int FindMaxElement(int[,] matrix)
        {
            (int indexIMaxElement, int indexJMaxElement) = FindIndexMaxElement(matrix);
            return matrix[indexIMaxElement, indexJMaxElement];
        }

        //+3.Find the index of the minimum element of the array.
        public static (int indexIMinElement, int indexJMinElement) FindIndexMinElement(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            (int indexIMinElement, int indexJMinElement) result = (0, 0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[result.indexIMinElement, result.indexJMinElement])
                    {
                        result = (i, j);
                    }
                }
            }
            return result;
        }

        //+4.Find the index of the maximum element of the array.
        public static (int indexIMaxElemen, int indexJMaxElement) FindIndexMaxElement(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            (int indexIMaxElement, int indexJMaxElement) result = (0, 0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[result.indexIMaxElement, result.indexJMaxElement])
                    {
                        result = (i, j);
                    }
                }
            }

            return result;
        }

        //+5.Find the number of array elements that are greater than all their neighbors at the same time.
        public static int CountElementsGreaterNighbors(int[,] matrix)
        {

            if (matrix == null)
            {
                throw new ArgumentException("Null matrix");
            }

            int countElements = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    int countNeighborsElements = 0;
                    for (int row1 = row - 1; row1 <= row + 1; row1++)
                    {
                        for (int colum1 = colum - 1; colum1 <= colum + 1; colum1++)
                        {
                            if (row1 < 0 || row1 == matrix.GetLength(0) || colum1 < 0 || colum1 == matrix.GetLength(1))
                            {
                            }
                            else
                            {
                                countNeighborsElements++;
                                if (matrix[row, colum] > matrix[row1, colum1])
                                {
                                    countNeighborsElements--;
                                }
                            }
                        }
                    }

                    if (countNeighborsElements == 1)
                    {
                        countElements++;
                    }
                }
            }

            return countElements;
        }

        //+6.Flip an array about its main diagonal.
        public static void SwapAboutMainDiagonalMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Null matrix");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    Swap(ref matrix[i, j], ref matrix[j, i]);
                }
            }
        }
    }
}
