using ProjectEuler;
using Xunit;

namespace ProjectEulerTests
{
    public class TestOtherMethods
    {
        [Fact]
        public void TestIsPythagoreanTriplet()
        {
            Assert.True(Problems1_10.IsPythagoreanTriplet(3, 4, 5));
        }

        [Fact]
        public void TestIsPalindrome()
        {
            Assert.True(Problems1_10.IsPalindrome(9119));
        }

        [Fact]
        public void TestSieve()
        {
            long[] sample = { 2, 3, 5, 7 };
            Assert.Equal(sample, Problems1_10.Sieve(10));
        }

        [Fact]
        public void TestOptimizedSieve()
        {
            long[] sample = { 2, 3, 5, 7 };
            Assert.Equal(sample, Problems1_10.OptimizedSieve(10));
        }

        [Fact]
        public void TestGetProduct()
        {
            int[,] grid = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            // Get product of values starting in row 0, item 1 and multiplying by numbers 2 to right of it
            // In this case -> 2 * 3 * 4 = 24
            Assert.Equal(24, Problems10_20.GetProduct(0, 1, 0, 1, 3, grid));
            // Start at row 1, item 0 and multiply 2 to right
            // 6 * 7 * 8 = 336
            Assert.Equal(336, Problems10_20.GetProduct(1, 0, 0, 1, 3, grid));
        }
    }
}
