//chamando a biblioteca 
using System.Security.Cryptography;

/*
V1
Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.
    ## Input (Entrada de Dados)O usuário digita número inteiro
    ## Processamento
        O sistema compara o número digitado com um número inteiro aleatório
    ## Output (Saída de Dados)
        O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um número secreto aleatório
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem de feedback
// 4. Nosso jogo deve permitir multiplas tentativas de adivinhação

//int numAleatorio = RandomNumberGenerator.GetInt32(NumeroMinimo, NumeroMaximo);
int numAleatorio = RandomNumberGenerator.GetInt32(1, 20);
//Console.WriteLine(numAleatorio);

bool jogoDeveContinuar = true;

while (jogoDeveContinuar)
{
    Console.Clear();

    Console.WriteLine("---------------------------------------");
    Console.WriteLine("##        Jogo de Adivinhação        ##");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("---- Digite algum número de 1 à 20 ----");


    Console.Write ("\n## Digite um número: ");
    string strNumDigitado = Console.ReadLine();
    int numDigitado = Convert.ToInt32(strNumDigitado);

    Console.WriteLine($"O número digitado foi: {strNumDigitado}");


    if (numAleatorio == numDigitado)
    {
        Console.WriteLine($"Parebéns, o número era realmente o {numAleatorio}");

    } else if (numAleatorio > numDigitado)
    {
        Console.WriteLine($"O número aleatorio é maior que o número digitado.");
        
    }
    else
    {
        Console.WriteLine($"O número digitado é menor que o número digitado.");
        
    }


    Console.WriteLine();
    Console.Write("Deseja continuar? (s/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jogoDeveContinuar = false;
    }
}