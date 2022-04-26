Console.WriteLine("Executando o projeto 7 - Escopo");

int idade = 17;
bool estaAcompanhado = true;
string mensagemAdicional;

if (estaAcompanhado == true)
{
    mensagemAdicional = "Está Acompanhado";

}
else
{
    mensagemAdicional = "Não está acompanhado";

}

if(idade >= 18 || estaAcompanhado)
{
    Console.WriteLine(mensagemAdicional);
    Console.WriteLine("Pode entrar.");
}
else
    Console.WriteLine("Não pode entrar")