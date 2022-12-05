Console.Write("Valor de A: ");
var a = double.Parse(Console.ReadLine()!);
Console.Write("Valor de B: ");
var b = double.Parse(Console.ReadLine()!);
Console.Write("Valor de C: ");
var c = double.Parse(Console.ReadLine()!);

var delta = Math.Pow(b, 2.0) - 4.0 * a * c;

if (a == 0 || delta < 0.0)
{
    Console.WriteLine("Impossível calcular");
}
else
{
    var r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
    var r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
    Console.WriteLine($"X1 = {r1:F5}");
    Console.WriteLine($"X2 = {r2:F5}");
}