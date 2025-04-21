namespace Dummy.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(8, result); // Check if the result is as expected.
        }
        [Fact]
        public void AddThreeNumbers()
        {
            // Arrange
            int a = 3;
            int b = 5;
            int c = 2;
            // Act
            int result = a + b + c;
            // Assert
            Assert.Equal(11, result); // Check if the result is as expected.
        }
    }
}