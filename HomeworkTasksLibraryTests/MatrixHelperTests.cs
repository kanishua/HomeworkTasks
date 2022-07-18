using HomeworkTasksLibrary;
using NUnit.Framework;
using System;

namespace HomeworkTasksLibraryTests
{
    class MatrixHelperTests
    {
        private static object[] DataForMinElement =
        {
            new object[] { new[,] { { 2 }, { 8 } }, 2 },
            new object[] { new[,] { { 2, 3 }, { 8, 1 } }, 1 },
            new object[] { new[,] { { -10, -5, 6 },{ 8, -3, 3 } }, -10 },
            new object[] { new[,] { { -5, 4, 6 },{ 8, -10, 3 } }, -10 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, 5 }, { 9, 4, -7 } }, -7 }
        };

        [TestCaseSource(nameof(DataForMinElement))]
        public void FindMinElement_WhenMatrixNotNullOrEmpty_ShouldFindMinElement
                  (int[,] matrix, int expected)
        {
            var actual = MatrixHelper.FindMinElement(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForMinElementMatrixNullOrEmpty =
        {
            new object[] {null, -1 },
            new object[] { new int [0,0], -1}            
        };

        [TestCaseSource(nameof(DataForMinElementMatrixNullOrEmpty))]
        public void FindMinElement_WhenMatrixNullOrEmpty_ShouldArgumentException
                  (int[,] matrix, int expected)
        {
            try
            {
                MatrixHelper.FindMinElement(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        private static object[] DataForMaxElement =
        {
            new object[] { new[,] { { 2 }, { 8 } }, 8 },
            new object[] { new[,] { { 2, 3 }, { 6, 1 } }, 6 },
            new object[] { new[,] { { 12, -5, 6 },{ 8, 1, 3 } }, 12 },
            new object[] { new[,] { { -5, 4, 6 },{ 8, 14, 3 } }, 14 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, 5 }, { 9, 4, 17 } }, 17 }
        };

        [TestCaseSource(nameof(DataForMaxElement))]
        public void FindMaxElement_WhenMatrixNotNullOrEmpty_ShouldFindMaxElement
                  (int[,] matrix, int expected)
        {
            var actual = MatrixHelper.FindMaxElement(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForMaxElementMatrixNullOrEmpty =
       {
            new object[] {null, -1 },
            new object[] { new int [0,0], -1}
        };

        [TestCaseSource(nameof(DataForMaxElementMatrixNullOrEmpty))]
        public void FindMaxElement_WhenMatrixNullOrEmpty_ShouldArgumentException
                  (int[,] matrix, int expected)
        {
            try
            {
                MatrixHelper.FindMaxElement(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        private static object[] DataForIndexMinElement =
        {
            new object[] { new[,] { { 2 }, { 8 } }, 0,0 },
            new object[] { new[,] { { 2, 3 }, { 8, 1 } }, 1,1 },
            new object[] { new[,] { { -10, -5, 6 },{ 8, -3, 3 } }, 0,0 },
            new object[] { new[,] { { -5, 4, 6 },{ 8, -10, 3 } }, 1,1 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, 5 }, { 9, 4, -7 } }, 2,2 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, -15 }, { 9, 4, -7 } }, 1,2 }
        };

        [TestCaseSource(nameof(DataForIndexMinElement))]
        public void FindIndexMinElement_WhenMatrixNotNullOrEmpty_ShouldFindIndexMinElement
                   (int[,] matrix, int expected1, int expected2)
        {
            (int actual1, int actual2) = MatrixHelper.FindIndexMinElement(matrix);

            Assert.AreEqual((expected1, expected2), (actual1, actual2));
        }

        private static object[] DataForIndexMinElementMatrixNullOrEmpty =
       {
            new object[] {null, -1,-1 },
            new object[] { new int [0,0], -1,-1}
        };

        [TestCaseSource(nameof(DataForIndexMinElementMatrixNullOrEmpty))]
        public void FindIndexMinElement_WhenMatrixNullOrEmpty_ShouldArgumentException
                  (int[,] matrix, int expected1, int expected2)
        {
            try
            {
                MatrixHelper.FindIndexMinElement(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        private static object[] DataForIndexMaxElement =
        {
            new object[] { new[,] { { 12 }, { 8 } }, 0,0 },
            new object[] { new[,] { { 3, 6 }, { 8, 1 } }, 1,0 },
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 } }, 1,1 },
            new object[] { new[,] { { 15, 4, 6 },{ 8, 10, 3 } }, 0,0 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, 15 }, { 9, 4, -7 } }, 1,2 },
            new object[] { new[,] { { 6, 8, -6 }, { 8, 9, 10}, { 9, 4, 15} }, 2,2 }
        };

        [TestCaseSource(nameof(DataForIndexMaxElement))]
        public void FindIndexMaxElement_WhenMatrixNotNullOrEmpty_ShouldFindIndexMaxElement
                   (int[,] matrix, int expected1, int expected2)
        {
            (int actual1, int actual2) = MatrixHelper.FindIndexMaxElement(matrix);

            Assert.AreEqual((expected1, expected2), (actual1, actual2));
        }

        private static object[] DataForIndexMaxElementMatrixNullOrEmpty =
       {
            new object[] {null, -1,-1 },
            new object[] { new int [0,0], -1,-1}
        };

        [TestCaseSource(nameof(DataForIndexMaxElementMatrixNullOrEmpty))]
        public void FindIndexMaxElement_WhenMatrixNullOrEmpty_ShouldArgumentException
                  (int[,] matrix, int expected1, int expected2)
        {
            try
            {
                MatrixHelper.FindIndexMaxElement(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        private static object[] DataForCountElementsGreaterNighbors =
        {
            new object[] { new[,] { { 12 }, { 7 } }, 1 },
            new object[] { new[,] { { 3, 6 }, { 8, 1 } }, 1 },
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 }, {3, 5, 4 } }, 1 },
            new object[] { new[,] { { 9, 5, 1, 3 }, { 2, 3, 5, 4 }, { 9, 14, 7, 1 }, { 8, 10, 1, 16 } }, 3 }
        };

        [TestCaseSource(nameof(DataForCountElementsGreaterNighbors))]
        public void CountElementsGreaterNighbors_WhenMatrixNotNullOrEmpty_ShouldCountElementsGreaterNighbors
                   (int[,] matrix, int expected)
        {
            int actual = MatrixHelper.CountElementsGreaterNighbors(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForCountElementsGreaterNighborsMatrixNull =
       {
            new object[] {null, -1 }
        };

        [TestCaseSource(nameof(DataForCountElementsGreaterNighborsMatrixNull))]
        public void CountElementsGreaterNighbors_WhenMatrixNull_ShouldArgumentException
                  (int[,] matrix, int expected)
        {
            try
            {
                MatrixHelper.CountElementsGreaterNighbors(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        private static object[] DataForSwapAboutMainDiagonalMatrix =
        {
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 10 }, { 3, 5, 4 } }, new[,] { { 2, 8, 3 }, { 3, 10, 5 }, { 6, 10, 4 } } },
            new object[] { new[,] { { 9, 5, 1, 3 }, { 2, 3, 5, 4 }, { 9, 14, 7, 1 }, { 8, 10, 1, 0 } },
                           new[,] { { 9, 2, 9, 8 }, { 5, 3, 14, 10 }, { 1, 5, 7, 1 }, { 3, 4, 1, 0 } } }
        };

        [TestCaseSource(nameof(DataForSwapAboutMainDiagonalMatrix))]
        public void SwapAboutMainDiagonalMatrix_WhenMatrixNotNull_ShouldSwapAboutMainDiagonalMatrix
                   (int[,] matrix, int[,] expected)
        {
            MatrixHelper.SwapAboutMainDiagonalMatrix(matrix);

            CollectionAssert.AreEqual(expected, matrix);
        }

        private static object[] DataForSwapAboutMainDiagonalMatrixMatrixNull =
       {
            new object[] {null, -1}
        };

        [TestCaseSource(nameof(DataForSwapAboutMainDiagonalMatrixMatrixNull))]
        public void SwapAboutMainDiagonalMatrix_WhenMatrixNull_ShouldArgumentException
                  (int[,] matrix, int expected)
        {
            try
            {
                MatrixHelper.SwapAboutMainDiagonalMatrix(matrix);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}