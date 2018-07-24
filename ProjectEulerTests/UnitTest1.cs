using ProjectEuler;
using Xunit;

namespace ProjectEulerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestProjEuler1()
        {
            Assert.Equal(233168.ToString(), Program.ProjEuler1().ToString());
        }

        [Fact]
        public void TestProjEuler2()
        {
            Assert.Equal(4613732.ToString(), Program.ProjEuler2().ToString());
        }

        [Fact]
        public void TestProjEuler3()
        {
            Assert.Equal(6857.ToString(), Program.ProjEuler3().ToString());
        }

        [Fact]
        public void TestProjEuler4()
        {
            Assert.Equal(906609.ToString(), Program.ProjEuler4_WhileLoop().ToString());
        }

        [Fact]
        public void TestProjEuler5()
        {
            Assert.Equal(232792560.ToString(), Program.ProjEuler5().ToString());
        }

        [Fact]
        public void TestProjEuler6()
        {
            Assert.Equal(25164150.ToString(), Program.ProjEuler6().ToString());
        }
    }
}
