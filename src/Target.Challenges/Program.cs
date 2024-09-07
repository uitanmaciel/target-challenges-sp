using Target.Challenges.FirstChallenge;


/*
 Desafio 01 - Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?

Challenge 01 - Look at the code snippet below: int INDEX = 12, SUM = 0, K = 1; while K < INDEX do { K = K + 1; SUM = SUM + K; } print(SUM);
At the end of the processing, what will be the value of the SUM variable?
*/
var sum = CalculateSum.ValueSum();
Console.WriteLine($"SOMA = {sum}");
