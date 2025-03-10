namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            int a = 2;
            int b = 3;

            int result = a + b;

            Assert.Equal(5, result);
        }
    }
}