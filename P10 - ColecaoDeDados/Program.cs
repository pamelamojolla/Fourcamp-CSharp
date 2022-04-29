Console.WriteLine("Executando o projeto 10 - Coleção de Dados. ");

void lista()
{
    //Declarando uma lista e atribuindo um valor (que é uma lista de 1 a 6)

    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };

    //Atribuindo o valor do numero que está na posição 2 na lista a uma variavel
    int numeroPos3 = numeros[2];

    //Adicionando um novo valor a lista (ele deve ser do mesmo tipo que foi definido na declaração)
    numeros.Add(7);

    //Adiciona o numero na posição que escolher
    numeros.Insert(0, 2);

    //Removendo o primeiro valor igual encontrado na lista
    numeros.Remove(5);

    //Removendo por posição
    numeros.RemoveAt(4);

    //Como obter os valores da lista uma a um usando um laço de repetição
    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }

}

void dicionario()
{
    //Declando um dicionario e atribuindo um valor (que é um dicionario vazio)
    Dictionary<int, string> clientes = new Dictionary<int, string>();

    //Atribuindo valores ao dicionario
    clientes.Add(1, "Gustavo");
    clientes.Add(2, "Lucas");
    clientes.Add(3, "Bruna");
    clientes.Add(4, "Fabio");

    //Mudando o valor do item pela chave
    clientes[2] = "Daniel";

    //Remove um item do dicionario pela chave
    clientes.Remove(1);

    //Como obter as chave e os valores do dicionario um a um usando laço de repetição
    foreach (KeyValuePair<int, string> cliente in clientes)
    {
        Console.WriteLine("Chave = " + cliente.Key);
        Console.WriteLine("Valor = " + cliente.Value);
    }

    //Como obter as chaves do dicionario usando laço de repetição
    foreach (int chave in clientes.Keys)
    {
        Console.WriteLine(chave);
    }

    //Como obter os valores do dicionario usando laço de repetição
    foreach (string valor in clientes.Values)
    {
        Console.WriteLine(valor);
    }
}


dicionario();



