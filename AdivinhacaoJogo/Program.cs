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
int numAleatorioNivel1 = RandomNumberGenerator.GetInt32(1, 40);
int numAleatorioNivel2 = RandomNumberGenerator.GetInt32(1, 30);
int numAleatorioNivel3 = RandomNumberGenerator.GetInt32(1, 10);
//Console.WriteLine(numAleatorioNivel1);

bool jogoDeveContinuar = true;

Console.Clear();

Console.WriteLine("----------------------------------------");
Console.WriteLine("##         Jogo de Adivinhação        ##");
Console.WriteLine("----------------------------------------");
Console.WriteLine("-- Digite sempre algum número inteiro --\n");

Console.WriteLine("Qual nível de jogo, vamos jogar? ");
Console.WriteLine("1 -> Nível 1 || 1 à 40 números");
Console.WriteLine("2 -> Nível 2 || 1 à 20 números");
Console.WriteLine("3 -> Nível 3 || 1 à 10 números");
Console.Write("=> ");
string strNivelDigitado = Console.ReadLine();
int nivelDigitado = Convert.ToInt32(strNivelDigitado);

if (strNivelDigitado != "1" && strNivelDigitado != "2" && strNivelDigitado != "3")
{
    Console.WriteLine("Número digitado não corresponde a nenhum nível...");
    return;
}

while (jogoDeveContinuar)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("##         Jogo de Adivinhação        ##");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-- Digite sempre algum número inteiro --\n");

    Console.Write ("\n## Digite um número: ");
    string strNumDigitado = Console.ReadLine();
    int numDigitado = Convert.ToInt32(strNumDigitado);

    //Console.WriteLine($"O número digitado foi: {strNumDigitado}");

    if (nivelDigitado == 1)
    {
        if (numAleatorioNivel1 == numDigitado)
        {
            Console.WriteLine($"Parebéns, o número era realmente o {numAleatorioNivel1}");
            Console.WriteLine("Até mais... saindo do nosso jogo.\n");
            return;


        }
        else if (numAleatorioNivel1 > numDigitado)
        {
            Console.WriteLine($"O número aleatorio é maior que o número digitado.");

        }
        else
        {
            Console.WriteLine($"O número digitado é menor que o número digitado.");

        }
    } else if (nivelDigitado == 2)
    {
        if (numAleatorioNivel2 == numDigitado)
        {
            Console.WriteLine($"Parebéns, o número era realmente o {numAleatorioNivel2}");
            Console.WriteLine("Até mais... saindo do nosso jogo.\n");
            return;


        }
        else if (numAleatorioNivel2 > numDigitado)
        {
            Console.WriteLine($"O número aleatorio é maior que o número digitado.");

        }
        else
        {
            Console.WriteLine($"O número digitado é menor que o número digitado.");

        }
    }else 
    {
        if (numAleatorioNivel3 == numDigitado)
        {
            Console.WriteLine($"Parebéns, o número era realmente o {numAleatorioNivel3}");
            Console.WriteLine("Até mais... saindo do nosso jogo.\n");
            return;


        }
        else if (numAleatorioNivel3 > numDigitado)
        {
            Console.WriteLine($"O número aleatorio é maior que o número digitado.");

        }
        else
        {
            Console.WriteLine($"O número digitado é menor que o número digitado.");

        }
    }

    Console.WriteLine();
    Console.Write("=> Deseja continuar? (s/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jogoDeveContinuar = false;
    }
}