using System.Text.Json.Serialization;

namespace Target.Challenges.ThirdChallenge;

public class Invoicing()
{
    [JsonPropertyName("dia")]
    public int Day { get; set; }
    
    [JsonPropertyName("valor")]
    public decimal Value { get; set; }

    private IList<Invoicing> DailyInvoicing { get; set; } = [];
    
    public Invoicing(int day, decimal value) : this()
    {
        Day = day;
        Value = value;
    }
    
    public Invoicing(IList<Invoicing> dailyInvoicing) : this() => DailyInvoicing = dailyInvoicing;
   
    /// <summary>
    /// Calculate the lowest billing (disregarding days with value 0)
    /// </summary>
    /// <returns>
    /// Returns the lowest billing.
    /// </returns>
    public decimal GetLowestBillingValue() => DailyInvoicing
        .Where(x => x.Value > 0)
        .Min(x => x.Value);
    
    
    /// <summary>
    /// Calculate the highest billing.
    /// </summary>
    /// <returns>
    /// Returns the highest billing.
    /// </returns>
    public decimal GetHighestBillingValue() => DailyInvoicing.Max(x => x.Value);
    
    /// <summary>
    /// Calculate the monthly average billing (disregarding days with value 0)
    /// </summary>
    /// <returns>Returns the monthly average billing</returns>
    public decimal GetMonthlyAverageBilling() => DailyInvoicing
        .Where(x => x.Value > 0)
        .Average(x => x.Value);
    
    /// <summary>
    /// Calculate the number of days in the month where the daily billing value was higher than the monthly average
    /// </summary>
    /// <returns>Returns the number of days in the month where the daily billing value was higher than the monthly average</returns>
    public int GetDaysAboveMonthlyAverage() => DailyInvoicing
        .Count(x => x.Value > GetMonthlyAverageBilling());
}