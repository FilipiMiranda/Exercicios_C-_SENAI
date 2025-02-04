// exercicio 1

//int[] num = { 1, 12, 123, 1234, 12345, 123456, 1234567 };

//foreach (int valor in num)
//{
//    Console.WriteLine(valor);
//}

// exercicio 2

//for (int i = 1; i <= 7; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j);  
//    }
//    for (int k = i; k < 7; k++)
//    {
//        Console.Write("*");  
//    }
//    Console.WriteLine(); 
//}

// exercicio 3

//Console.Write("Informe um Número: ");
//double num1 = double.Parse(Console.ReadLine());

//Console.Write("Informe outro Número: ");
//double num2 = double.Parse(Console.ReadLine());

//if( num1 == 0)
//{
//    Console.WriteLine("Não é possivel dividir");   
//}
//else if (num2 == 0)
//{
//    Console.WriteLine("Não é possivel dividir");
//}
//else
//{
//double divisao = num1 / num2;

//Console.WriteLine("Resultado: " + divisao);

//}


// exercicio 4

//Console.Write("Digite um número: ");
//if (int.TryParse(Console.ReadLine(), out int numero))
//{
//    for (int i = 1; i < numero; i += 2)
//    {
//        Console.WriteLine($"\nTabuada do {i}:");
//        for (int j = 1; j <= 10; j++)
//        {
//            Console.WriteLine($"{i} x {j} = {i * j}");
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Por favor, insira um número válido.");
//}

// exercicio 5

//int idadeMaisVelha = 0;
//double alturaMaisAlta = 0.0;

//for (int i = 1; i <= 5; i++)
//{
//    Console.Write($"Digite a idade da pessoa {i}: ");
//    int idade = int.Parse(Console.ReadLine());

//    Console.Write($"Digite a altura da pessoa {i} (em metros): ");
//    double altura = double.Parse(Console.ReadLine());

//    if (idade > idadeMaisVelha)
//    {
//        idadeMaisVelha = idade;
//    }

//    if (altura > alturaMaisAlta)
//    {
//        alturaMaisAlta = altura;
//    }
//}

//Console.WriteLine($"A idade da pessoa mais velha é: {idadeMaisVelha} anos");
//Console.WriteLine($"A altura da pessoa mais alta é: {alturaMaisAlta} metros");

// exercicio 6

//Console.Write("Digite o número de alunos na sala: ");
//int numAlunos = int.Parse(Console.ReadLine());

//double somaNotas = 0.0;

//for (int i = 1; i <= numAlunos; i++)
//{
//    Console.Write($"Digite a nota do aluno {i}: ");
//    double nota = double.Parse(Console.ReadLine());
//    somaNotas += nota;
//}

//double media = somaNotas / numAlunos;
//Console.WriteLine($"A média da sala é: {media:F2}");

// exercicio 7

//Console.Write("Digite uma palavra: ");
//string palavra = Console.ReadLine().ToLower().Replace(" ", "");

//string reverso = "";
//for (int i = palavra.Length - 1; i >= 0; i--)
//{
//    reverso += palavra[i];
//}

//if (palavra == reverso)
//{
//    Console.WriteLine("A palavra é um palíndromo.");
//}
//else
//{
//    Console.WriteLine("A palavra não é um palíndromo.");
//}


