while (true)
{
    Console.Write("Senha: ");
    var senha = int.Parse(Console.ReadLine()!);

    if (senha == 2002)
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
    else
    {
        Console.WriteLine("Senha inválida");
    }

}