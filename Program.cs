Console.WriteLine("-- O maior entre os dois números --");
Console.WriteLine("");
Console.WriteLine("Digite um número para ser comparado...");

int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número para ser comparado...");

int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"O número ({numero1}) é maior que o número ({numero2})!");
}

else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"O número ({numero1}) é menor que o número ({numero2})!");
}
Console.WriteLine("");
Console.ResetColor();