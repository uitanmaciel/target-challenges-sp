using System.Globalization;
using System.Text.Json;
using Target.Challenges.FifthChallenge;
using Target.Challenges.FirstChallenge;
using Target.Challenges.FourthChallenge;
using Target.Challenges.SecondChallenge;
using Target.Challenges.ThirdChallenge;

/*
 Desafio 01 - Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?

Challenge 01 - Look at the code snippet below: int INDEX = 12, SUM = 0, K = 1; while K < INDEX do { K = K + 1; SUM = SUM + K; } print(SUM);
At the end of the processing, what will be the value of the SUM variable?
*/
Console.WriteLine("[Desafio 01] - Calculando a soma dos números de 1 a 13...\n");
var sum = CalculateSum.ValueSum();
Console.WriteLine($"SOMA = {sum}\n");

/*
 Desafio 02 - Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos
 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem 
 que desejar onde, informado um número, ele calcule a sequência de Fibonacci e 
 retorne uma mensagem avisando se o número informado pertence ou não a sequência.
 
 
Challenge 02 - Given the Fibonacci sequence, where it starts with 0 and 1 and the next value will always be the sum of the
 2 previous values (example: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...), write a program in the language
 you want where, informed a number, it calculates the Fibonacci sequence and
 return a message warning if the informed number belongs to the sequence or not.
 */

Console.WriteLine("[Desafio 02] - Verificando se um número pertence a sequência de Fibonacci...\n");
Console.WriteLine("Digite um número para verificar se ele pertence a sequência de Fibonacci: ");
var number = int.Parse(Console.ReadLine()!);
var isFibonacci = FibonacciSequence.IsFibonacci(number);
Console.WriteLine(isFibonacci 
  ? "O número informado pertence a sequência de Fibonacci." 
  : "O número informado não pertence a sequência de Fibonacci.");

/*
Desafio 03 - Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, que calcule e retorne:
 - O menor valor de faturamento ocorrido em um dia do mês;
 - O maior valor de faturamento ocorrido em um dia do mês;
 - Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
 
Challenge 03 - Given an array that stores the daily billing value of a distributor, make a program that calculates and returns:
 - The lowest billing value that occurred on a day of the month;
 - The highest billing value that occurred on a day of the month;
 - Number of days in the month where the daily billing value was higher than the monthly average.
 */

Console.WriteLine("[Desafio 03] - Calculando o menor, maior faturamento e a média do faturamento mensal...\n");
var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
var filePath = Path.Combine(projectDirectory, "ThirdChallenge","data.json");
var jsonData = File.ReadAllText(filePath);
var dailyInvoicing = JsonSerializer.Deserialize<IList<Invoicing>>(jsonData);
var invoicing = new Invoicing(dailyInvoicing);
var lowestBilling = invoicing.GetLowestBillingValue();
var highestBilling = invoicing.GetHighestBillingValue();
var monthlyAverageBilling = invoicing.GetMonthlyAverageBilling();
var daysAboveMonthlyAverage = invoicing.GetDaysAboveMonthlyAverage();

Console.WriteLine($"Menor faturamento: R$ {lowestBilling.ToString("C", NumberFormatInfo.CurrentInfo)}");
Console.WriteLine($"Maior faturamento: R$ {highestBilling.ToString("C", NumberFormatInfo.CurrentInfo)}");
Console.WriteLine($"Média do faturamento mensal: R$ {monthlyAverageBilling}");
Console.WriteLine($"Número de dias com faturamento acima da média mensal: {daysAboveMonthlyAverage}\n");

/*
Desafio 04 - Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
 - SP – R$67.836,43
 - RJ – R$36.678,66
 - MG – R$29.229,88
 - ES – R$27.165,48
 - Outros – R$19.849,53

Escreva um programa onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

Challenge 04 - Given the monthly billing value of a distributor, detailed by state:
 - SP - R$ 67,836.43
 - RJ - R$ 36,678.66
 - MG - R$ 29,229.88
 - ES - R$ 27,165.48
 - Others - R$ 19,849.53
 
Write a program where you calculate the percentage of representation that each state had within the total monthly value of the distributor.
 */
 
 var spRevenue = 67836.43M;
 var rjRevenue = 36678.66M;
 var mgRevenue = 29229.88M;
 var esRevenue = 27165.48M;
 var otherRevenue = 19849.53M;
 
 var revenueShares = new List<RevenueShare>
 {
     new RevenueShare("SP", spRevenue),
     new RevenueShare("RJ", rjRevenue),
     new RevenueShare("MG", mgRevenue),
     new RevenueShare("ES", esRevenue),
     new RevenueShare("Outros", otherRevenue)
 };
 
 var revenueShare = new RevenueShare(revenueShares);
 revenueShare.ShowRevenueShare();
 
 /*
Desafio 05 - Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;

Challenge 05 - Write a program that reverses the characters of a string.

IMPORTANT:
a) This string can be entered through any input of your choice or can be previously defined in the code;
b) Avoid using ready-made functions, such as reverse;
*/

var value = "charInverted[i] = value[value.Length - 1 - i];";
var invertedValue = ReverseString.Reverse(value);
Console.WriteLine($"Valor original: {value}");
Console.WriteLine($"Valor invertido: {invertedValue}");