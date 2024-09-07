using Target.Challenges.SecondChallenge;

namespace Target.Challenges.Tests.SecondChallenge;

[TestClass]
public class FibonacciSequenceTest
{
    [TestMethod]
    public void IsFibonacci_WhenNumberIsZero_ShouldReturnTrue()
    {
        // Arrange
        const int number = 0;

        // Act
        var result = FibonacciSequence.IsFibonacci(number);

        // Assert
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void IsFibonacci_WhenNumberIsOne_ShouldReturnTrue()
    {
        // Arrange
        const int number = 1;

        // Act
        var result = FibonacciSequence.IsFibonacci(number);

        // Assert
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void IsFibonacci_WhenNumberIsBelongs_ShouldReturnTrue()
    {
        // Arrange
        const int number = 55;

        // Act
        var result = FibonacciSequence.IsFibonacci(number);

        // Assert
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void IsFibonacci_WhenNumberIsNotBelongs_ShouldReturnFalse()
    {
        // Arrange
        const int number = 10;

        // Act
        var result = FibonacciSequence.IsFibonacci(number);

        // Assert
        Assert.IsFalse(result);
    }
}