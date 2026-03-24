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
// 5. Adicioncar opção de niveis de jogo
// 6. Adcionar a opção de contagem

//int numAleatorio = RandomNumberGenerator.GetInt32(NumeroMinimo, NumeroMaximo);
int numAleatorioNivel1 = RandomNumberGenerator.GetInt32(1, 40);
int numAleatorioNivel2 = RandomNumberGenerator.GetInt32(1, 20);
int numAleatorioNivel3 = RandomNumberGenerator.GetInt32(1, 10);
//Console.WriteLine(numAleatorioNivel1);

Console.Clear();

Console.WriteLine("----------------------------------------");
Console.WriteLine("##         Jogo de Adivinhação        ##");
Console.WriteLine("----------------------------------------");
Console.WriteLine("-- Digite sempre algum número inteiro --\n");

Console.WriteLine("Qual nível de jogo, vamos jogar? ");
Console.WriteLine("1 -> Nível 1 || 8 tentativas e 40 números");
Console.WriteLine("2 -> Nível 2 || 5 tentativas e 20 números");
Console.WriteLine("3 -> Nível 3 || 3 tentativas e 10 números");
Console.Write("=> ");
string strNivelDigitado = Console.ReadLine();
int nivelDigitado = Convert.ToInt32(strNivelDigitado);

// validação para os niveis escolhidos
if (strNivelDigitado != "1" && strNivelDigitado != "2" && strNivelDigitado != "3")
{
    Console.WriteLine("Número digitado não corresponde a nenhum nível...");
    return;
}

// if com a validação do numero digitado
if (nivelDigitado == 1)
{

    // iniciando o loop, com contadores para repetição
    int contadorNivel1 = 1;
    int limiteNivel1 = 9;
    while (contadorNivel1 < limiteNivel1)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("##         Jogo de Adivinhação        ##");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-- Digite sempre algum número inteiro --\n");

        // contagem simples para calcular as tentativas faltantes
        int tentativasRestantes = limiteNivel1 - contadorNivel1;
        Console.Write($"\n## Faltam {tentativasRestantes} tentativa(s) ");
        Console.Write("\n## Digite um número: ");
        string strNumDigitado = Console.ReadLine();
        int numDigitado = Convert.ToInt32(strNumDigitado);

        if (numAleatorioNivel1 == numDigitado)
        {
            Console.WriteLine($"Parebéns, o número era realmente o {numAleatorioNivel1}");
            Console.WriteLine("\nAté mais... saindo do nosso jogo.\n");
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

        Console.WriteLine();
        Console.Write("=> Deseja continuar? (s/N): ");
        string opcaoContinuar = Console.ReadLine();

        if (opcaoContinuar == "S" || opcaoContinuar == "s")
        {
            //incrementando o contador e validando se não atingiu o maximo permitido
            contadorNivel1++;
            if (contadorNivel1 >= limiteNivel1)
            {
                Console.WriteLine("\n## GAME OVER...Número de tentativas atingido. ##\n");
                return;
            }
        }else
        {
            Console.WriteLine("\nAté mais... Saindo do jogo.");
            return;
        }
    }
}
else if (nivelDigitado == 2)
{
    int contadorNivel2 = 1;
    int limiteNivel2 = 6;
    while (contadorNivel2 < limiteNivel2)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("##         Jogo de Adivinhação        ##");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-- Digite sempre algum número inteiro --\n");

        int tentativasRestantes = limiteNivel2 - contadorNivel2;
        Console.Write($"\n## Faltam {tentativasRestantes} tentativa(s) ");
        Console.Write("\n## Digite um número: ");
        string strNumDigitado = Console.ReadLine();
        int numDigitado = Convert.ToInt32(strNumDigitado);

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


        Console.WriteLine();
        Console.Write("=> Deseja continuar? (s/N): ");
        string opcaoContinuar = Console.ReadLine();

        if (opcaoContinuar == "S" || opcaoContinuar == "s")
        {
            contadorNivel2++;
            if (contadorNivel2 >= limiteNivel2)
            {
                Console.WriteLine("\n## GAME OVER...Número de tentativas atingido. ##\n");
                return;
            }
        }
        else
        {
            Console.WriteLine("\nAté mais... Saindo do jogo.");
            return;
        }
    }
} else
{
    int contadorNivel3 = 1;
    int limiteNivel3 = 4;
    while (contadorNivel3 < limiteNivel3)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("##         Jogo de Adivinhação        ##");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-- Digite sempre algum número inteiro --\n");

        int tentativasRestantes = limiteNivel3 - contadorNivel3;
        Console.Write($"\n## Faltam {tentativasRestantes} tentativa(s) ");
        Console.Write("\n## Digite um número: ");
        string strNumDigitado = Console.ReadLine();
        int numDigitado = Convert.ToInt32(strNumDigitado);


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

        
        Console.WriteLine();
        Console.Write("=> Deseja continuar? (s/N): ");
        string opcaoContinuar = Console.ReadLine();

        if (opcaoContinuar == "S" || opcaoContinuar == "s")
        {
            contadorNivel3++;
            if (contadorNivel3 >= limiteNivel3)
            {
                Console.WriteLine("\n## GAME OVER...Número de tentativas atingido. ##\n");
                return;
            }
        }
        else
        {
            Console.WriteLine("\nAté mais... Saindo do jogo.");
            return;
        }
    }
}