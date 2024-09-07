using Target.Challenges.ThirdChallenge;

namespace Target.Challenges.Tests.ThirdChallengeTest;

[TestClass]
public class InvoicingTest
{
    [TestMethod]
    public void GetLowestBillingValue_WhenCalled_ShouldReturnLowestBillingValue()
    {
        // Arrange
        var invoicing = new Invoicing(Data());

        // Act
        var result = invoicing.GetLowestBillingValue();

        // Assert
        Assert.AreEqual(373.7838M, result);
    }
    
    [TestMethod]
    public void GetHighestBillingValue_WhenCalled_ShouldReturnHighestBillingValue()
    {
        // Arrange
        var invoicing = new Invoicing(Data());

        // Act
        var result = invoicing.GetHighestBillingValue();

        // Assert
        Assert.AreEqual(48924.2448M, result);
    }
    
    [TestMethod]
    public void GetMonthlyAverageBilling_WhenCalled_ShouldReturnMonthlyAverageBilling()
    {
        // Arrange
        var invoicing = new Invoicing(Data());

        // Act
        var result = invoicing.GetMonthlyAverageBilling();

        // Assert
        Assert.AreEqual(20865.3702M, Math.Round(result, 4));
    }
    
    [TestMethod]
    public void GetDaysAboveMonthlyAverage_WhenCalled_ShouldReturnDaysAboveMonthlyAverage()
    {
        // Arrange
        var invoicing = new Invoicing(Data());

        // Act
        var result = invoicing.GetDaysAboveMonthlyAverage();

        // Assert
        Assert.AreEqual(10, result);
    }

    private IList<Invoicing> Data()
    {
        return new List<Invoicing>
        {
            new Invoicing { Day = 1, Value = 22174.1664M },
            new Invoicing { Day = 2, Value = 24537.6698M },
            new Invoicing { Day = 3, Value = 26139.6134M },
            new Invoicing { Day = 4, Value = 0.0M },
            new Invoicing { Day = 5, Value = 0.0M },
            new Invoicing { Day = 6, Value = 26742.6612M },
            new Invoicing { Day = 7, Value = 0.0M },
            new Invoicing { Day = 8, Value = 42889.2258M },
            new Invoicing { Day = 9, Value = 46251.174M },
            new Invoicing { Day = 10, Value = 11191.4722M },
            new Invoicing { Day = 11, Value = 0.0M },
            new Invoicing { Day = 12, Value = 0.0M },
            new Invoicing { Day = 13, Value = 3847.4823M },
            new Invoicing { Day = 14, Value = 373.7838M },
            new Invoicing { Day = 15, Value = 2659.7563M },
            new Invoicing { Day = 16, Value = 48924.2448M },
            new Invoicing { Day = 17, Value = 18419.2614M },
            new Invoicing { Day = 18, Value = 0.0M },
            new Invoicing { Day = 19, Value = 0.0M },
            new Invoicing { Day = 20, Value = 35240.1826M },
            new Invoicing { Day = 21, Value = 43829.1667M },
            new Invoicing { Day = 22, Value = 18235.6852M },
            new Invoicing { Day = 23, Value = 4355.0662M },
            new Invoicing { Day = 24, Value = 13327.1025M },
            new Invoicing { Day = 25, Value = 0.0M },
            new Invoicing { Day = 26, Value = 0.0M },
            new Invoicing { Day = 27, Value = 25681.8318M },
            new Invoicing { Day = 28, Value = 1718.1221M },
            new Invoicing { Day = 29, Value = 13220.495M },
            new Invoicing { Day = 30, Value = 8414.61M }
        };
    }
}