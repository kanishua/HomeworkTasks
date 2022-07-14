using HomeworkTasksLibrary;
using NUnit.Framework;

namespace HomeworkTasksLibraryTests
{
    public class ArrayHelperTests
    {

        [TestCase(new[] { 10 }, 10)]
        [TestCase(new[] { 10, 5 }, 5)]
        [TestCase(new[] { -5, 2, 10, 3 }, -5)]
        [TestCase(new[] { 10, 4, 1, 3, 8 }, 1)]
        [TestCase(new[] { 10, 5, 5, -3 }, -3)]
        public void FindMinElement_WhenArrayNotNull_ShouldFindMinElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.FindMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 10 }, 10)]
        [TestCase(new[] { 8, 5 }, 8)]
        [TestCase(new[] { -5, 2, 7, 3 }, 7)]
        [TestCase(new[] { -5, 4, 1, 3, 9 }, 9)]
        [TestCase(new[] { 15, 5, 5, -3 }, 15)]
        public void FindMaxElement_WhenArrayNotNull_ShouldFindMaxElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.FindMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 10 }, 0)]
        [TestCase(new[] { 10, 5 }, 1)]
        [TestCase(new[] { -5, 2, 10, 3 }, 0)]
        [TestCase(new[] { 10, 4, 1, 3, 8 }, 2)]
        [TestCase(new[] { 10, 5, 5, -3 }, 3)]
        public void FindIndexMinElement_WhenArrayFilled_ShouldFindIndexMinElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.FindIndexMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 10 }, 0)]
        [TestCase(new[] { 8, 5 }, 0)]
        [TestCase(new[] { -5, 2, 7, 3 }, 2)]
        [TestCase(new[] { -5, 4, 1, 3, 9 }, 4)]
        [TestCase(new[] { 15, 5, 5, -3 }, 0)]
        public void FindIndexMaxElement_WhenArrayFilled_ShouldFindIndexMaxElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.FindIndexMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 10 }, 0)]
        [TestCase(new[] { 8, 5 }, 5)]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5 }, 8)]
        [TestCase(new[] { 11, 19, -10, 1, 15, -5 }, 15)]
        [TestCase(new[] { 1, 3, -1, -4, 5, 10 }, 9)]
        public void CountSumElementsWithOddIndex_WhenArrayNotNull_ShouldCountSumElementsWithOddIndex
            (int[] array, int expected)
        {
            int actual = ArrayHelper.CountSumElementsWithOddIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 9 }, new[] { 9, 1 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5 }, new[] { -5, 5, 4, -1, 9, 1 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5, 7 }, new[] { 7, -5, 5, 4, -1, 9, 1 })]
        public void MakeReverseArray_WhenArrayNotNull_ShouldMakeReverseArray
            (int[] array, int[] expected)
        {
            ArrayHelper.MakeReverseArray(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestCase(new[] { 11 }, 1)]
        [TestCase(new[] { 8, 5 }, 1)]
        [TestCase(new[] { 1, 9, 2, -5 }, 3)]
        [TestCase(new[] { 11, 19, -10, 10, 15, -5 }, 4)]
        [TestCase(new[] { 1, 3, -1, -3, 5, 11 }, 6)]
        public void CountNumberOddElements_WhenArrayNotNull_ShouldCountNumberOddElements
            (int[] array, int expected)
        {
            int actual = ArrayHelper.CountNumberOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 9 }, new[] { 9, 1 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5 }, new[] { 4, 5, -5, 1, 9, -1 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5, 7 }, new[] { 5, -5, 7, 4, 1, 9, -1 })]
        public void SwapPlaceHalfArray_WhenArrayNotNull_ShouldSwapPlaceHalfArray
           (int[] array, int[] expected)
        {
            ArrayHelper.SwapPlaceHalfArray(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestCase(new[] { 9 }, new[] { 9 })]
        [TestCase(new[] { 9, 1 }, new[] { 1, 9 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5 }, new[] { -5, -1, 1, 4, 5, 9 })]
        [TestCase(new[] { 1, 9, -1, 4, 5, -5, 6 }, new[] { -5, -1, 1, 4, 5, 6, 9 })]
        public void SortArrayByBubble_WhenArrayNotNull_ShouldSortArrayByBubble
           (int[] array, int[] expected)
        {
            ArrayHelper.SortArrayByBubble(array);
            CollectionAssert.AreEqual(expected, array);
        }
    }
}