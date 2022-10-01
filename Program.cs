int n1, n2, resto;
Console.WriteLine("---------------");
Console.WriteLine("---Multiplos---");
Console.WriteLine("---------------");
Console.WriteLine();

Console.Write("Digite um número ............: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é Multiplo de ....: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

resto = n1 % n2;

if (resto == 0)
{
    Console.WriteLine($"{n1} é multiplo de {n2}");
}
else 
{
    Console.WriteLine($"{n1} não é multiplo de {n2}");  
}
Console.WriteLine("Obrigado por utilizar o programa");

