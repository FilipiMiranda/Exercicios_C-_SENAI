// exercicio 1

//decimal precoMenos12 = 1.00m;
//decimal precoMais12 = 1.30m;
//decimal precoUnitario;

//Console.Write("Qual é a quantidade de maçãs que irá querer: ");
//int quantidade = int.Parse(Console.ReadLine());

//if (quantidade <= 12)
//{
//    precoUnitario = precoMenos12;
//}
//else
//{
//    precoUnitario = precoMais12;
//}

//decimal total = quantidade * precoUnitario;

//Console.WriteLine($"Preço unitário: R$ {precoUnitario:F2}");
//Console.WriteLine($"Total a pagar: R$ {total:F2}");

// exercicio 2


//Console.Write("Informe um número: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Informe outro número: ");
//int num2 = int.Parse(Console.ReadLine());

//Console.Write("Informe o ultimo número: ");
//int num3 = int.Parse(Console.ReadLine());

//int maior = Math.Max(num1, Math.Max(num2, num3));
//int menor = Math.Min(num1, Math.Min(num2, num3));

//int meio = 0;

//if (num1 > num2 && num1 < num3)
//{
//    meio = num1;
//}
//else if (num2 > num1 && num2 < num3)
//{
//    meio = num2;
//}
//else if (num3 > num1 && num3 < num2)
//{
//    meio = num3;
//}

//Console.WriteLine($"Numero maior: {maior:F2}");
//Console.WriteLine($"Numero do meio: {meio:F2}");
//Console.WriteLine($"Numero menor: {menor:F2}");

// exercicio 3

//Console.Write("Qual é o seu salário: R$");
//double salario = double.Parse(Console.ReadLine());

//Console.Write("Quanto de Vendas você fez: R$");
//int vendas = int.Parse(Console.ReadLine());

//double comissao = 0;

//if (vendas < 1500)
//{
//    comissao = vendas * 0.03;
//}
//else if (vendas >= 1500)
//{
//    comissao = vendas * 0.05;
//}

//double salarioTotal = comissao + salario;

//Console.WriteLine("Valor da Comissão: R$" + comissao);
//Console.WriteLine("Salário Total: R$" + salarioTotal);

// exercicio 4


// Solicita ao usuário que informe um ano
//    Console.Write("Digite um ano: ");
//    int ano = int.Parse(Console.ReadLine());

//    Verifica se o ano é bissexto
//    bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);

//    Exibe o resultado
//    if (ehBissexto)
//    {
//        Console.WriteLine($"O ano {ano} é bissexto.");
//    }
//    else
//    {
//        Console.WriteLine($"O ano {ano} não é bissexto.");
//    }


//    // exercicio 5
//    Console.Write("Digite o preço normal da entrada: ");
//    double precoNormal = double.Parse(Console.ReadLine());


//    Console.Write("Digite o dia da semana (1 a 7): ");
//    int diaSemana = int.Parse(Console.ReadLine());


//    Console.Write("É dia de música ao vivo? (S/N): ");
//    char musicaAoVivo = char.ToUpper(Console.ReadLine()[0]);


//    double precoFinal = precoNormal;

//    if (diaSemana == 2 || diaSemana == 3 || diaSemana == 5)
//    {
//        precoFinal -= 10;
//    }

//    if (musicaAoVivo == 'S')
//    {
//        precoFinal += 7.50;
//    }

//    Console.WriteLine($"O preço final da entrada é: R$ {precoFinal:F2}");

////exercicio 6

//    Console.Write("Digite o valor de A: ");
//    double A = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Digite o valor de B: ");
//    double B = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Digite o valor de C: ");
//    double C = Convert.ToDouble(Console.ReadLine());

//    if (EhTriangulo(A, B, C))
//    {
//        Console.WriteLine("Os valores informados formam um triângulo do tipo: " + TipoTriangulo(A, B, C));
//    }
//    else
//    {
//        Console.WriteLine("Os valores informados não formam um triângulo.");
//    }


//static bool EhTriangulo(double a, double b, double c)
//{
//    return a + b > c && a + c > b && b + c > a;
//}

//static string TipoTriangulo(double a, double b, double c)
//{
//    if (a == b && b == c)
//    {
//        return "Equilátero";
//    }
//    else if (a == b || a == c || b == c)
//    {
//        return "Isósceles";
//    }
//    else
//    {
//        return "Escaleno";
//    }
//}
