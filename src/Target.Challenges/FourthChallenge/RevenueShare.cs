namespace Target.Challenges.FourthChallenge;

public class RevenueShare()
{
    public string State { get; set; } = string.Empty;
    public decimal Revenue { get; set; }

    private IList<RevenueShare> RevenueShares { get; set; } = [];
    
    public RevenueShare(string state, decimal revenue) : this()
    {
        State = state;
        Revenue = revenue;
    }
    
    public RevenueShare(IList<RevenueShare> revenueShares) : this() => RevenueShares = revenueShares;
    
    /// <summary>
    /// Calculate the total revenue of all states
    /// </summary>
    /// <returns>Returns the total revenue of all states</returns>
    public decimal GetTotalRevenue() => RevenueShares.Sum(x => x.Revenue);
    
    /// <summary>
    /// Calculate the revenue of a specific state
    /// </summary>
    /// <param name="state">Ticker of the state</param>
    /// <returns>Returns the revenue of a specific state</returns>
    public decimal GetStateRevenue(string state) => RevenueShares.FirstOrDefault(x => x.State == state)?.Revenue ?? 0;
    
    /// <summary>
    /// Calculate the percentage of revenue of a specific state
    /// </summary>
    /// <param name="state">Ticker of the state</param>
    /// <returns>Returns the percentage of revenue of a specific state</returns>
    public double GetStateRevenuePercentage(string state) => (double)(GetStateRevenue(state) / GetTotalRevenue() * 100);
    
    /// <summary>
    /// Show the percentage of representation of each state
    /// </summary>
    public void ShowRevenueShare()
    {
        foreach (var revenueShare in RevenueShares)
        {
            var percentage = GetStateRevenuePercentage(revenueShare.State);
            
            if(revenueShare.State == "Outros")
            {
                Console.WriteLine($"Os {revenueShare.State} estados representam {percentage.ToString("F2")}% do faturamento total.");
                continue;
            }
            Console.WriteLine($"O estado {revenueShare.State} representa {percentage.ToString("F2")}% do faturamento total.");
        }
    }
}