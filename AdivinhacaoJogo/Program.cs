//chamando a biblioteca 
using System.Security.Cryptography;

/*v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.
    ## Input (Entrada de Dados)O usuário digita número inteiro
    ## Processamento
        O sistema compara o número digitado com um número inteiro aleatório
    ## Output (Saída de Dados)
        O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um número secreto aleatório

Console.Clear();

Console.WriteLine("---------------------------------------");
Console.WriteLine("##        Jogo de Adivinhação        ##");
Console.WriteLine("---------------------------------------");
Console.Write ("\nDigite um número: ");
string strNumDigitado = Console.ReadLine();


//int numAleatorio = RandomNumberGenerator.GetInt32(NumeroMinimo, NumeroMaximo);
int numAleatorio = RandomNumberGenerator.GetInt32(1, 20);

Console.WriteLine($"O número digitado foi: {strNumDigitado}");
Console.WriteLine($"O número aleatorio foi: {numAleatorio}");
Console.ReadLine();