/*v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.
    ## Input (Entrada de Dados)O usuário digita número inteiro
    ## Processamento
        O sistema compara o número digitado com um número inteiro aleatório
    ## Output (Saída de Dados)
        O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado

Console.Clear();

Console.WriteLine("---------------------------------------");
Console.WriteLine("##        Jogo de Adivinhação        ##");
Console.WriteLine("---------------------------------------");
Console.Write ("\nDigite um número: ");
string strNumdigitado = Console.ReadLine();

Console.WriteLine($"O número digitado foi: {strNumdigitado}");
Console.ReadLine();