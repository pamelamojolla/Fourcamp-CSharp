Console.WriteLine("Executando o projeto 8 - Laço de Repetição. ");

/*
double valorInvestido = 1000;

//0.36%
valorInvestido += valorInvestido * 0.0036;

Console.WriteLine("Após 1 mês, você terá: + " + valorInvestido.ToString("C"));

valorInvestido += valorInvestido * 0.0036;

Console.WriteLine("Após 2 mês, você terá: + " + valorInvestido.ToString("C"));

*/

double valorInvestido = 1000;
int contadorMes = 0;

while(contadorMes < 12)
{
    valorInvestido += valorInvestido * 0.0036;
    Console.WriteLine($"Após {contadorMes + 1}, mês você terá: " + valorInvestido.ToString("c"));

    contadorMes++;

}

/* Elabore um programa em C# para testar se uma senha digitada pelo
 * usuário é igual a senha1214. Se a senha estiver correta mostre na tela: 
 * "Acesso permitido", do contrário emita a mensagem: “Senha Incorreta. Digite novamente”.
 * Observação: O usuário tem 3 chances para acertar a senha. Caso não consiga acertar, mostrar na tela:
   “Senha Bloqueada! Procure o setor responsável”
*/

Console.WriteLine("Digite sua Senha: ");
string senha = Console.ReadLine();

int chances = 2;

while(senha != "senha1214" && chances > 0)
{
    Console.WriteLine($"Senha incorreta! Você tem mais {chances} chances.");
    Console.WriteLine("Digite sua senha novamente: ");
    senha = Console.ReadLine();
    chances--;
}

if(senha == "senha1214")
{
    Console.WriteLine("Acesso permitido!");
}
else
    Console.WriteLine("Senha Bloequeada! Procure o setor responsável");