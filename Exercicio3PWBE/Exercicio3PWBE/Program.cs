// exercicio 1

//Random random = new Random();
//int[] sorteio = new int[6];
//int[] aposta = new int[6];

//Console.WriteLine("Jogo da Mega-Sena! " +
//    "\nEscolha 6 números entre 1 e 60:");

//for (int i = 0; i < 6; i++)
//{
//    Console.Write($"Número {i + 1}: ");
//    int numero;
//    while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 60 || aposta.Contains(numero))
//    {
//        Console.WriteLine("Número inválido ou repetido! Escolha outro:");
//    }
//    aposta[i] = numero;
//}

//for (int i = 0; i < 6; i++)
//{
//    int numero;
//    do
//    {
//        numero = random.Next(1, 61);
//    } while (sorteio.Contains(numero));

//    sorteio[i] = numero;
//}

//Console.WriteLine("\nNúmeros sorteados: " + string.Join(", ", sorteio));

//int acertos = aposta.Count(n => sorteio.Contains(n));

//Console.WriteLine($"Você acertou {acertos} números!");

//if (acertos == 6)
//    Console.WriteLine("Parabéns! Você ganhou na Mega-Sena!");
//else if (acertos >= 4)
//    Console.WriteLine("Você ganhou um prêmio menor!");
//else
//    Console.WriteLine("Não foi dessa vez. Tente novamente!")

// exercicio 2

string[] nomes = new string[10];

Console.WriteLine("Digite 10 nomes (sem repetir):");

for (int i = 0; i < 10; i++)
{
string nome;
do
{
Console.Write($"Nome {i + 1}: ");
nome = Console.ReadLine();

if (nomes.Contains(nome))
{
Console.WriteLine("Nome já digitado! Escolha outro.");
}

} while (nomes.Contains(nome)); // Repete até o usuário digitar um nome único

nomes[i] = nome;
}

// Agora lê um novo nome para verificar se já foi digitado antes
string novoNome;
do
{
Console.Write("\nDigite um novo nome para verificar: ");
novoNome = Console.ReadLine();

if (nomes.Contains(novoNome))
{
Console.WriteLine("Nome já foi digitado antes! Digite outro.");
}

} while (nomes.Contains(novoNome)); // Exige um nome que ainda não foi digitado

Console.WriteLine($"Nome '{novoNome}' é novo e foi aceito!");

