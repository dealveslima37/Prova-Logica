Console.Write("Raio círculo: ");
var raio = double.Parse(Console.ReadLine()!);

var area = Math.PI * Math.Pow(raio, 2.0);

Console.WriteLine($"A = {area:F4}");