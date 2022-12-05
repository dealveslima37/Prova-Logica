using System.Globalization;

Console.WriteLine("Entre com os dados da peça 1 ");
Console.Write("Código da peça: ");
var codigoDaPeca1 = int.Parse(Console.ReadLine()!);
Console.Write("Quantidade de peças: ");
var qtdPecas1 = int.Parse(Console.ReadLine()!);
Console.Write("Valor da peça R$: ");
var precoDaPeca1 = double.Parse(Console.ReadLine()!);

var valorDaPeca1 = qtdPecas1 * precoDaPeca1;

Console.WriteLine();

Console.WriteLine("Entre com os dados da peça 2");
Console.Write("Código da peça: ");
var codigoDaPeca2 = int.Parse(Console.ReadLine()!);
Console.Write("Quantidade de peças: ");
var qtdPecas2 = int.Parse(Console.ReadLine()!);
Console.Write("Valor da peça R$: ");
var precoDaPeca2 = double.Parse(Console.ReadLine()!);

var valorDaPeca2 = qtdPecas2 * precoDaPeca2;

var valorAPagar = valorDaPeca1 + valorDaPeca2;

Console.WriteLine($"Valor a pagar R$ {valorAPagar:F2}");