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
/*
V2
2. Implemente uma funcionalidade de Validação de Números Repetidos

    O jogador deve ser informado caso o número que está tentando adivinhar já tenha sido informado anteriormente na mesma rodada.

3. Implemente uma funcionalidade de Pontuação, onde:

    O jogador começa com uma pontuação máxima, por exemplo, 1000 pontos.
    A pontuação é calculada com base na proximidade do palpite em relação ao número secreto.
    A cada tentativa errada, o jogador perde pontos de acordo com a distância do número secreto:
    Se a diferença entre o número secreto e o palpite for de 10 ou mais, o jogador perde 100 pontos.
    Se a diferença for entre 5 e 9, o jogador perde 50 pontos.
    Se a diferença for entre 1 e 4, o jogador perde 20 pontos.
    Quando o jogador acerta o número, sua pontuação final é registrada.

Exemplo:
    1. Número secreto: 50
    2. Palpite do jogador: 30 → diferença de 20 → o jogador perde 100 pontos (de 1000 para 900).
    3. Palpite do jogador: 48 → diferença de 2 → o jogador perde 20 pontos (de 900 para 880).
    4. Palpite do jogador: 50 → acerto → jogo termina com 888 pontos.
*/

bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("##         Jogo de Adivinhação        ##");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-- Digite sempre algum número inteiro --\n");
    Console.WriteLine("## Qual nível de jogo, vamos jogar?   ##");
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("1 -> Díficil || 03 tentativas e 100 números");
    Console.WriteLine("2 -> Médio   || 05 tentativas e 50  números");
    Console.WriteLine("3 -> Fácil   || 10 tentativas e 20  números");
    Console.WriteLine("-----------------------------------------------");

    Console.Write("=> ");
    string nivelDigitado = Console.ReadLine();

    int numAleatorio;
    int limiteNivel;

    // opções de escolha, conforme o que o usuário digitou
    switch (nivelDigitado)
    {
        case "1":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            limiteNivel = 3;
            break;

        case "2":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            limiteNivel = 5;
            break;

        case "3":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            limiteNivel = 10;
            break;

        default:
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Número digitado não corresponde a nenhum nível...");
            Console.Write("Clique ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int pontuacao = 1000;

    //guardando os numeros digitados em um array
    int[] numerosDigitados = new int[limiteNivel];
    int contadorNumerosDigitados = 0;


    // laço percorre a quantidade de tentativas disponiveis 
    for (int tentativaAtual = 1; tentativaAtual <= limiteNivel; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("##         Jogo de Adivinhação        ##");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"## Faltam {tentativaAtual} de {limiteNivel}                      ##");
        Console.WriteLine("-----------------------------------------------");

        Console.Write("Digite um número: ");
        int numDigitado = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;

        // laço percorre o array para comparar se o numero digitado já foi digitado anteriormente
        for (int indiceAtual = 0; indiceAtual < numerosDigitados.Length; indiceAtual++)
        {
            // validando se o numero já foi digitado
            if (numerosDigitados[indiceAtual] == numDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        // informando ao usuário que o numero já foi digitado e remove a tentativa da adivinhação
        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("## Você já digitou esse número, tente novamente. ##");
            Console.WriteLine("---------------------------------------------------");

            Console.Write("Clique ENTER para continuar...");
            Console.ReadLine();

            tentativaAtual--;
            continue;
        }

        // validando se ainda há espaços disponiveis no array
        if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numDigitado;
            contadorNumerosDigitados++;
        }
        else
        {
            //se tiver cheio o array, "reinicializa o array" e recomeça o array pela possição 0
            numerosDigitados = new int[limiteNivel];
            contadorNumerosDigitados = 0;

            numerosDigitados[contadorNumerosDigitados] = numDigitado;
            contadorNumerosDigitados++;
        }

        if (numDigitado == numAleatorio)
        {
            Console.WriteLine("Parabéns, você acertou! O número era " + numAleatorio);
            break;
        }
        else if (numDigitado > numAleatorio)
        {
            Console.WriteLine("O número digitado foi maior que o número secreto!");
        }
        else
        {
            Console.WriteLine("O número digitado foi menor que o número secreto!");
        }

        // recebendo em variavel o resultado do numero aleatorio e o numero digitado e tirando a diferença
        /* 
            usando o metodo Math.Abs para receber o valor absoluto 
            int a = Math.Abs(-10);   // resultado: 10
            double c = Math.Abs(-3.14); // resultado: 3.14
        */
        int diferencaNumerica = Math.Abs(numAleatorio - numDigitado); // 90 - 100 = 10

        // validando a pontuação, com base na difença entre o numero aleatorio e o digitado
        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferencaNumerica >= 5 && diferencaNumerica < 10)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.WriteLine("-----------------------------------------------");
        Console.Write("Clique ENTER para continuar...");
        Console.ReadLine();
    }

    Console.WriteLine("-----------------------------------------------");
    Console.Write("Deseja continuar? (s/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jogoDeveContinuar = false;
    }
}