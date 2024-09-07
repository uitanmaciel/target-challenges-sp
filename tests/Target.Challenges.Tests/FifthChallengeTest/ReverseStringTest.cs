using Target.Challenges.FifthChallenge;

namespace Target.Challenges.Tests.FifthChallengeTest;

[TestClass]
public class ReverseStringTest
{
    [TestMethod]
    public void ReverseString_WhenCalledWithValidString_ShouldReturnReversedString()
    {
        // Arrange
        var input = "Test";
        var expected = "tseT";

        // Act
        var result = ReverseString.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}