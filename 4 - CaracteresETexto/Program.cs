Console.WriteLine("Executando o projeto 4 - Caracteres e TExto.");

//o tipo char 16 bits, então ele comporta uma letra
char primeiraLetra = 'a';
Console.WriteLine(primeiraLetra);

//convertendo um numero inteiro em char usando cast - tabela ascii
primeiraLetra = (char)98;
Console.WriteLine(primeiraLetra);

string titulo = "Fourcamp stack C# .NET " + 2022;

if (true)
{
    if (true)
    {
        string lista = @$"{primeiraLetra}
- .NET";
        Console.WriteLine(lista);
    }
}

primeiraLetra = titulo[0];
char ultimaLetra = titulo[titulo.Length - 1];

Console.WriteLine(primeiraLetra);
Console.WriteLine(ultimaLetra);