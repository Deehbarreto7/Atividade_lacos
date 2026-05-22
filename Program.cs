Console.Write("Quantas vezes quer exibir? ");
int maximo = Convert.ToInt32(Console.ReadLine());

int contador = 0;

while (contador < maximo)
{
    if (contador % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    int repeticoes = 0;
    while(repeticoes < 3)
    {
        Console.Write("Hello, World! ");
        repeticoes = repeticoes + 1;
    }

    contador = contador + 1;

    Console.WriteLine(contador);
}

Console.ResetColor();