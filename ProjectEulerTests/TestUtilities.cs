using ProjectEuler;
using Xunit;

namespace ProjectEulerTests
{
    public class TestUtilities
    {
        [Fact]
        public void TestIsPrime()
        {
            Assert.True(Utilities.isPrime(27644437));
        }
    }
}
