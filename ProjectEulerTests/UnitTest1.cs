using ProjectEuler;
using Xunit;

namespace ProjectectEulerTests
{
    public class UnitTest1
    {
        Problems1_10 test = new Problems1_10();

        [Fact]
        public void TestProjectEuler1()
        {
            Assert.Equal(233168.ToString(), Problems1_10.ProjectEuler1().ToString());
        }

        [Fact]
        public void TestProjectEuler2()
        {
            Assert.Equal(4613732.ToString(), Problems1_10.ProjectEuler2().ToString());
        }

        [Fact]
        public void TestProjectEuler3()
        {
            Assert.Equal(6857.ToString(), Problems1_10.ProjectEuler3().ToString());
        }

        [Fact]
        public void TestProjectEuler4()
        {
            Assert.Equal(906609.ToString(), Problems1_10.ProjectEuler4_WhileLoop().ToString());
        }

        [Fact]
        public void TestProjectEuler5()
        {
            Assert.Equal(232792560.ToString(), Problems1_10.ProjectEuler5().ToString());
        }

        [Fact]
        public void TestProjectEuler6()
        {
            Assert.Equal(25164150.ToString(), Problems1_10.ProjectEuler6().ToString());
        }

        [Fact]
        public void TestProjectEuler7()
        {
            Assert.Equal(104743.ToString(), Problems1_10.ProjectEuler7().ToString());
        }

        [Fact]
        public void TestProjectEuler8()
        {
            Assert.Equal(23514624000.ToString(), Problems1_10.ProjectEuler8().ToString());
        }
    }
}
