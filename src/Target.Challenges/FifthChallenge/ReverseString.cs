namespace Target.Challenges.FifthChallenge;

public static class ReverseString
{
    /// <summary>
    /// Reverse a string
    /// </summary>
    /// <param name="value">String for reverse</param>
    /// <returns>Returns string inverted.</returns>
    public static string Reverse(string value)
    {
        var charInverted = new char[value.Length];
        
        for (int i = 0; i < value.Length; i++)
            charInverted[i] = value[value.Length - 1 - i];
        
        return new string(charInverted);
    }
}