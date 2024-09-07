namespace Target.Challenges.FirstChallenge;

public static class CalculateSum
{
    public static int ValueSum()
    {
        const int index = 13;
        var sum = 0; 
        var k = 1;

        while (k < index)
        {    
            k++;
            Console.WriteLine($"Interação {k - 1}: \nK = K({k - 1}) + 1 = {k}\nsoma = {sum} + {k} = {sum + k}\n");
            sum += k;
        }
        return sum;
    }
}