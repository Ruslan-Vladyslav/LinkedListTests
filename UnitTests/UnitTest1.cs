namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            int a = 2;
            int b = 3;
            int result = a + b;

            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            int a = 2;
            int b = 3;
            int result = a * b;

            Assert.Equal(6, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            int a = 5;
            int b = 3;
            int result = a - b;

            Assert.Equal(2, result);
        }
    }
}