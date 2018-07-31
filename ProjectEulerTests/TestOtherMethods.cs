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
    }
}
