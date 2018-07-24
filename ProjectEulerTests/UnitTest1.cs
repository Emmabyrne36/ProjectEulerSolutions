using ProjectectEuler;
using Xunit;

namespace ProjectectEulerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestProjectEuler1()
        {
            Assert.Equal(233168.ToString(), Program.ProjectEuler1().ToString());
        }

        [Fact]
        public void TestProjectEuler2()
        {
            Assert.Equal(4613732.ToString(), Program.ProjectEuler2().ToString());
        }

        [Fact]
        public void TestProjectEuler3()
        {
            Assert.Equal(6857.ToString(), Program.ProjectEuler3().ToString());
        }

        [Fact]
        public void TestProjectEuler4()
        {
            Assert.Equal(906609.ToString(), Program.ProjectEuler4_WhileLoop().ToString());
        }

        [Fact]
        public void TestProjectEuler5()
        {
            Assert.Equal(232792560.ToString(), Program.ProjectEuler5().ToString());
        }

        [Fact]
        public void TestProjectEuler6()
        {
            Assert.Equal(25164150.ToString(), Program.ProjectEuler6().ToString());
        }
    }
}
