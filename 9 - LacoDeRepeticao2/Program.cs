Console.WriteLine("Executando Projeto 9 - Laço de Repetição 2");

void Ex1()
{
    double valorInvestido = 1000;

    for (int contadorMes = 0; contadorMes < 12; contadorMes++)
    {
        valorInvestido += valorInvestido * 0.0036;
        Console.WriteLine($"Após {contadorMes + 1} meses, você terá " + valorInvestido.ToString("c"));
    }
}


void Ex2()
{
    /* Elabore um programa em C# para testar se uma senha digitada pelo
     * usuário é igual a senha1214. Se a senha estiver correta mostre na tela: 
     * "Acesso permitido", do contrário emita a mensagem: “Senha Incorreta. Digite novamente”.
     * Observação: O usuário tem 3 chances para acertar a senha. Caso não consiga acertar, mostrar na tela:
       “Senha Bloqueada! Procure o setor responsável”
    */

    Console.WriteLine("Digite sua senha: ");
    string senha = Console.ReadLine();

    for (int chances = 2; senha != "senha1214" && chances > 0; chances--)
    {
        Console.WriteLine($"Senha incorreta. Você tem mais {chances} chances. ");
        senha = Console.ReadLine();

        if (senha == "1111")
            break;
    }

    if (senha == "senha1214")
    {
        Console.WriteLine("Acesso Permitido.");
    }
    else
        Console.WriteLine("Senha Bloqueada! Procure o setor responsável.");
}

Ex1();
