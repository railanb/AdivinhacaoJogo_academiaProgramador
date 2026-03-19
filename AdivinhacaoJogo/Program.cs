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
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem de feedback
// 4. Nosso jogo deve permitir multiplas tentativas de adivinhação

//Console.Clear();

Console.WriteLine("---------------------------------------");
Console.WriteLine("##        Jogo de Adivinhação        ##");
Console.WriteLine("---------------------------------------");


Console.Write ("\n## Digite um número: ");
string strNumDigitado = Console.ReadLine();
int numDigitado = Convert.ToInt32(strNumDigitado);


//int numAleatorio = RandomNumberGenerator.GetInt32(NumeroMinimo, NumeroMaximo);
int numAleatorio = RandomNumberGenerator.GetInt32(1, 20);
//Console.WriteLine(numAleatorio);


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

Console.ReadLine();