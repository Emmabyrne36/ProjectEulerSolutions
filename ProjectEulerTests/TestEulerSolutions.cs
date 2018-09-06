using ProjectEuler;
using Xunit;

namespace ProjectectEulerTests
{
    public class TestEulerSolutions
    {
        [Fact]
        public void TestProjectEuler1()
        {
            Assert.Equal(233168, Problems1_10.ProjectEuler1());
        }

        [Fact]
        public void TestProjectEuler2()
        {
            Assert.Equal(4613732, Problems1_10.ProjectEuler2()); ;
        }

        [Fact]
        public void TestProjectEuler3()
        {
            Assert.Equal(6857, Problems1_10.ProjectEuler3());
        }

        [Fact]
        public void TestProjectEuler4()
        {
            Assert.Equal(906609, Problems1_10.ProjectEuler4_WhileLoop());
        }

        [Fact]
        public void TestProjectEuler5()
        {
            Assert.Equal(232792560, Problems1_10.ProjectEuler5());
        }

        [Fact]
        public void TestProjectEuler6()
        {
            Assert.Equal(25164150, Problems1_10.ProjectEuler6());
        }

        [Fact]
        public void TestProjectEuler7()
        {
            Assert.Equal(104743, Problems1_10.ProjectEuler7());
        }

        [Fact]
        public void TestProjectEuler8()
        {
            Assert.Equal(23514624000, Problems1_10.ProjectEuler8());
        }

        [Fact]
        public void TestProjectEuler9()
        {
            Assert.Equal(31875000, Problems1_10.ProjectEuler9());
        }

        [Fact]
        public void TestProjectEuler10()
        {
            Assert.Equal(142913828922, Problems1_10.ProjectEuler10());
        }

        [Fact]
        public void TestProjectEuler11()
        {
            Assert.Equal(70600674, Problems11_14.ProjectEuler11());
        }

        [Fact]
        public void TestProjectEuler12()
        {
            Assert.Equal(76576500, Problems11_14.ProjectEuler12());
        }

        [Fact]
        public void TestProjectEuler13()
        {
            Assert.Equal(5537376230, Problems11_14.ProjectEuler13());
        }

        [Fact]
        public void TestProjectEuler14_WithoutCaching()
        {
            Assert.Equal(837799, Problems11_14.ProjectEuler14_WithoutCaching());
        }

        [Fact]
        public void TestProjectEuler14_WithCaching()
        {
            Assert.Equal(837799, Problems11_14.ProjectEuler14_WithCaching());
        }

        [Fact]
        public void TestProjectEuler15()
        {
            Assert.Equal(137846528820, Problems15_20.ProjectEuler15());
        }

        [Fact]
        public void TestProjectEuler16()
        {
            Assert.Equal(1366, Problems15_20.ProjectEuler16());
        }

        [Fact]
        public void TestProjectEuler17()
        {
            Assert.Equal(21124, Problems15_20.ProjectEuler17());
        }
    }
}
