using HomeworkTasksLibrary;
using NUnit.Framework;

namespace HomeworkTasksLibraryTests
{
    class MatrixHelperTests
    {
        private static object[] DataForMinElement =
        {
            new object[] { new[,] { { 2 }, { 8 } }, 2},
            new object[] { new[,] { { 2, 3 }, { 8, 1 } }, 1},
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 } }, 1},
            new object[] { new[,] { { 6, 8, 6 }, { 8, 9, 5 }, { 9, 4, 7 } }, 4}
        };

        [TestCaseSource(nameof(DataForMinElement))]
        public void FindMinElement_WhenMatrixNotNull_ShouldFindMinElement
                   (int[,] matrix, int expected)
        {
            var actual = MatrixHelper.FindMinElement(matrix);
            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForMaxElement =
        {
            new object[] { new[,] { { 2 }, { 8 } }, 8},
            new object[] { new[,] { { 2, 3 }, { 6, 1 } }, 6},
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 } }, 10},
            new object[] { new[,] { { 6, 8, 6 }, { 8, 9, 5 }, { 2, 4, 7 } }, 9}
        };

        [TestCaseSource(nameof(DataForMaxElement))]
        public void FindMaxElement_WhenMatrixNotNull_ShouldFindMaxElement
                  (int[,] matrix, int expected)
        {
            var actual = MatrixHelper.FindMaxElement(matrix);
            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForIndexMinElement =
        {
            new object[] { new[,] { { 12 }, { 8 } }, 1,0 },
            new object[] { new[,] { { 3, 6 }, { 8, 1 } }, 1,1 },
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 } }, 1,2 },
            new object[] { new[,] { { 6, 15, 6 }, { 8, 9, 5 }, { 9, 4, 7 } }, 2,1 }
        };

        [TestCaseSource(nameof(DataForIndexMinElement))]
        public void FindIndexMinElement_WhenMatrixNotNull_ShouldFindIndexMinElement
                   (int[,] matrix, int expected1, int expected2)
        {
            (int actual1, int actual2) = MatrixHelper.FindIndexMinElement(matrix);
            Assert.AreEqual((expected1, expected2), (actual1, actual2));
        }

        private static object[] DataForIndexMaxElement =
        {
            new object[] { new[,] { { 12 }, { 8 } }, 0,0 },
            new object[] { new[,] { { 3, 6 }, { 8, 1 } }, 1,0 },
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 } }, 1,1 },
            new object[] { new[,] { { 6, 1, 6 }, { 8, 3, 5 }, { 9, 14, 7 } }, 2,1 }
        };

        [TestCaseSource(nameof(DataForIndexMaxElement))]
        public void FindIndexMaxElement_WhenMatrixNotNull_ShouldFindIndexMaxElement
                   (int[,] matrix, int expected1, int expected2)
        {
            (int actual1, int actual2) = MatrixHelper.FindIndexMaxElement(matrix);
            Assert.AreEqual((expected1, expected2), (actual1, actual2));
        }

        private static object[] DataForCountElementsGreaterNighbors =
        {
            new object[] { new[,] { { 12 }, { 7 } }, 1 },
            new object[] { new[,] { { 3, 6 }, { 8, 1 } }, 1 },
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 }, {3, 5, 4 } }, 1 },
            new object[] { new[,] { { 9, 5, 1, 3 }, { 2, 3, 5, 4 }, { 9, 14, 7, 1 }, { 8, 10, 1, 0 } }, 2 }
        };

        [TestCaseSource(nameof(DataForCountElementsGreaterNighbors))]
        public void CountElementsGreaterNighbors_WhenMatrixNotNull_ShouldCountElementsGreaterNighbors
                   (int[,] matrix, int expected)
        {
            int actual = MatrixHelper.CountElementsGreaterNighbors(matrix);
            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForSwapAboutMainDiagonalMatrix =
        {
            new object[] { new[,] { { 2, 3, 6 }, { 8, 10, 1 }, {3, 5, 4 } }, new[,] { { 2, 8, 3 }, { 3, 10, 5 }, {6, 1, 4 } } },
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
    }
}
