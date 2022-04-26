Console.WriteLine("3 _ Conversões e outros tipos numericos.");

double salario = 1200.50;
Console.WriteLine(salario);

//Declarando e atribuindo um valor double em uma variavel inteira usando uma conversão cast
int salarioInteiro = (int)salario;
Console.WriteLine(salarioInteiro);

//Fazendo conversão
string numerostr = "10";
int numero = Int32.Parse(numerostr); //convertendo uma string para numero inteiro
salario = Double.Parse(numerostr); //convertendo uma string em double


//short ocupa 16 bits de memoria 
short num = 1000;

//int ocupa 32 bits de memoria
int numeroInteiro = 1000000000;

//long ocupa 64 bits de memoria
long numInteiroLong = 1000000000000000000;

Console.WriteLine(num + numeroInteiro + numInteiroLong);
