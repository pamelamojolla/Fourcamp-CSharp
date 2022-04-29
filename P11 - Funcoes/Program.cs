Console.WriteLine("Executando o projeto 11 - Funções");

string Input(string mensagem)
{
    Console.WriteLine(mensagem);
    string resposta = Console.WriteLine();
    return resposta;
}


bool ValidaNumero(int numero)
{
    if (numero <= 0)
        return false;
    if(numero % 2 == 0)
        return false;

    return true;
}

Console.WriteLine("Digite um numero: ");
int numero = Int32.Parse(Console.ReadLine());   

bool isValid = ValidaNumero (numero);

if(isValid)
    Console.WriteLine("É valido.");
else
    Console.WriteLine("Não é valido.");

string nome = Input("Digite seu nome: ");