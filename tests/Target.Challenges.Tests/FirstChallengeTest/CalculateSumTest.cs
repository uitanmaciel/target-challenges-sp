using Target.Challenges.FirstChallenge;

namespace Target.Challenges.Tests.FirstChallengeTest;

[TestClass]
public class CalculateSumTest
{
    [TestMethod]
    public void ValueSum_Test()
    {
        // Arrange
        const int expected = 90;
        // Act
        var result = CalculateSum.ValueSum();
        // Assert
        Assert.AreEqual(expected, result);
    }
}