var menu = "Código Especificação    Preço\n" +
           "1      Cachorro Quente  R$ 4,00\n" +
           "2      X-Salada         R$ 4,50\n" +
           "3      X-Bacon          R$ 5,00\n" +
           "4      Torrada Simples  R$ 2,00\n" +
           "5      Refrigerante     R$ 1,50\n";

Console.WriteLine(menu);
Console.Write("Opção: ");
var op = int.Parse(Console.ReadLine()!);
Console.Write("Quantidade: ");
var qtd = int.Parse(Console.ReadLine()!);
var valor = 0.0;

switch (op)
{
    case 1:
        valor = qtd * 4.00;
        break;
    case 2:
        valor = qtd * 4.50;
        break;
    case 3:
        valor = qtd * 5.00;
        break;
    case 4:
        valor = qtd * 2.00;
        break;
    case 5:
        valor = qtd * 1.50;
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;


}

Console.WriteLine($"Valor R$ {valor:F2}");