Console.Write("Quantos valores serão lidos: ");
var n = int.Parse(Console.ReadLine()!);
var inInterval = 0;
var outInterval = 0;

for (int i = 0; i < n; i++)
{
    Console.Write("Digite um valor: ");
    var valor = int.Parse(Console.ReadLine()!);

    if (valor >= 10 && valor <= 20)
    {
        inInterval++;
    }
    else
    {
        outInterval++;
    }

}

Console.WriteLine($"{inInterval} in");
Console.WriteLine($"{outInterval} out");