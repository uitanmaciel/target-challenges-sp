namespace Target.Challenges.SecondChallenge;

public static class FibonacciSequence
{
    public static bool IsFibonacci(int number)
    {
        // Se o número for 0 ou 1, ele é um número de Fibonacci.
        // If the number is 0 or 1, it is a Fibonacci number.
        if (number is 0 or 1)
            return true;

        var previous = 0;
        var current = 1;

        while (current < number)
        {
            var next = previous + current;
            previous = current;
            current = next;
        }

        // Se o número informado for igual ao número atual, ele é um número de Fibonacci.
        // If the number entered is equal to the current number, it is a Fibonacci number.
        return current == number;
    }
}