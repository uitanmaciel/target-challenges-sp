using Target.Challenges.FourthChallenge;

namespace Target.Challenges.Tests.FourthChallengeTest;

[TestClass]
public class RevenueShareTest
{
    [TestMethod]
    public void Should_Return_Revenue_Share()
    {
        // Arrange
        const double spRevenuePercentage = 37.53;
        const double rjRevenuePercentage = 20.29;
        const double mgRevenuePercentage = 16.17;
        const double esRevenuePercentage = 15.03;
        const double othersRevenuePercentage = 10.98;
        var revenueShare = new RevenueShare(_revenueShares);

        // Act
        var resultSp = revenueShare.GetStateRevenuePercentage(_revenueShares[0].State);
        var resultRj = revenueShare.GetStateRevenuePercentage(_revenueShares[1].State);
        var resultMg = revenueShare.GetStateRevenuePercentage(_revenueShares[2].State);
        var resultEs = revenueShare.GetStateRevenuePercentage(_revenueShares[3].State);
        var resultOthers = revenueShare.GetStateRevenuePercentage(_revenueShares[4].State);

        // Assert
        Assert.AreEqual(spRevenuePercentage, Math.Round(resultSp, 2));
        Assert.AreEqual(rjRevenuePercentage, Math.Round(resultRj, 2));
        Assert.AreEqual(mgRevenuePercentage, Math.Round(resultMg, 2));
        Assert.AreEqual(esRevenuePercentage, Math.Round(resultEs, 2));
        Assert.AreEqual(othersRevenuePercentage, Math.Round(resultOthers, 2));
    }
    
    private IList<RevenueShare> _revenueShares = new List<RevenueShare>
    {
        new RevenueShare("SP", 67836.43M),
        new RevenueShare("RJ", 36678.66M),
        new RevenueShare("MG", 29229.88M),
        new RevenueShare("ES", 27165.48M),
        new RevenueShare("Outros", 19849.53M)
    };
}