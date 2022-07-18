using HomeworkTasksLibrary;
using System;

namespace HomeworkTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelper.GanerateArray(10);
            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("1.Find the minimum element of an array:");
            Console.WriteLine(ArrayHelper.FindMinElement(array));
            Console.WriteLine("2.Find the maximum element of an array:");
            Console.WriteLine(ArrayHelper.FindMaxElement(array));
            Console.WriteLine("3.Find the index of the minimum element of the array:");
            Console.WriteLine(ArrayHelper.FindIndexMinElement(array));
            Console.WriteLine("4.Find the index of the maximum element of the array:");
            Console.WriteLine(ArrayHelper.FindIndexMaxElement(array));
            Console.WriteLine("5.Calculate the sum of array elements with odd indices:");
            Console.WriteLine(ArrayHelper.CountSumElementsWithOddIndex(array));
            Console.WriteLine("6.Make an array reverse (an array in the opposite direction):");
            ArrayHelper.MakeReverseArray(array);
            PrintArray(array);
            Console.WriteLine("7.Count the number of odd array elements:");
            Console.WriteLine(ArrayHelper.CountNumberOddElements(array));
            Console.WriteLine("8.Swap the first and second half of the array:");
            ArrayHelper.SwapPlaceHalfArray(array);
            PrintArray(array);
            Console.WriteLine("9.Sort the array in ascending order in bubble way:");
            ArrayHelper.SortArrayByBubble(array);
            PrintArray(array);
            Console.WriteLine("10.Sort the array in descending order in inserts way");
            ArrayHelper.SortArrayByInsert(array);
            PrintArray(array);
            Console.WriteLine();

            int[,] matrix = MatrixHelper.GanerateMatrix(5, 4);
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("1.Find the minimum element of an array:");
            Console.WriteLine(MatrixHelper.FindMinElement(matrix));
            Console.WriteLine("2.Find the maximum element of an array:");
            Console.WriteLine(MatrixHelper.FindMaxElement(matrix));
            Console.WriteLine("3.Find the index of the minimum element of the array:");
            Console.WriteLine(MatrixHelper.FindIndexMinElement(matrix));
            Console.WriteLine("4.Find the index of the maximum element of the array:");
            Console.WriteLine(MatrixHelper.FindIndexMaxElement(matrix));
            Console.WriteLine("5.Find the number of array elements that are greater than all their neighbors at the same time:");
            Console.WriteLine(MatrixHelper.CountElementsGreaterNighbors(matrix));
            Console.WriteLine("6.Flip an array about its main diagonal:");
            MatrixHelper.SwapAboutMainDiagonalMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("1.Create class Shape and derived Triangle, Rectangle, Circle(Perimetr, Square):");
            InterfaceExample();
            GAME.RUNGAME();


        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void InterfaceExample()
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Rectangle(4, 5);
            shapes[1] = new Triangle(3, 4, 5);
            shapes[2] = new Circle(3);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Perimetr {shapes[i].shapeName} = {shapes[i].GetPerimetr()}");
                Console.WriteLine($"Square {shapes[i].shapeName} = {shapes[i].GetSquare()}");
            }
        }
    }
}
