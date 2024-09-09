// See https://aka.ms/new-console-template for more information
using AulasPOO.uteis;
using System.Globalization;
int opcao = 0, num1, num2, num3, lado1, lado2, lado3;
decimal precoOriginal, desconto, resultadoDesconto;

do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Multiplicar");
    Console.WriteLine("3) Fatorial");
    Console.WriteLine("4) Subtrair");
    Console.WriteLine("5) Dividir");
    Console.WriteLine("6) Calcular desconto");
    Console.WriteLine("7) Verificar triangulo");
    Console.WriteLine("0) Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Fim do Programa");
            break;
        case 1:
            LerDoisNumerosInteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1,num2);
            Console.WriteLine($"O resultado da soma de {num1} com {num2} é: {resultado}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da multiplicação de {num1} por {num2} é {Calculadora.Multiplica(num1,num2)}");
            break;
        case 3:
            Console.WriteLine("Entre com o numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado do fatorial de {num3} é {Calculadora.Fatorial(num3)}");
            break;
        case 4:
            LerDoisNumerosInteiros();
            var calc2 = new Calculadora();
            int resultado2 = calc2.Subtrair(num1 ,num2);
            Console.WriteLine($"O resultado da subtração de {num1} por {num2} é {resultado2}");
            break;
        case 5:
            LerDoisNumerosInteiros();
            var (result, resto) = Calculadora.Dividir(num1, num2);
            Console.WriteLine($"O resultado da divisão de {num1} por {num2} é {result} e o resto que sobrou é {resto} ");
            break;
        case 6:
            try
            {
                var des = new Desconto();
                Console.WriteLine("Entre com o preço do produto: ");
                precoOriginal = decimal.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);
                Console.WriteLine("Entre com o desconto: ");
                desconto = decimal.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);
                resultadoDesconto = des.calculaDesconto(precoOriginal, desconto);
                resultadoDesconto = Math.Round(resultadoDesconto, 2);
                if (resultadoDesconto == precoOriginal)
                {
                    Console.WriteLine($"Com o desconto de {desconto}%, o valor do produto não sofreu alterações");
                    break;
                }
                Console.WriteLine($"O produto com preço R${precoOriginal} passou a valer R${resultadoDesconto} com o desconto de {desconto}%. ");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            break;
        case 7:
            try
            {
                LerTresNumerosInteiros();
                Console.WriteLine($"Os números {lado1}, {lado2} e {lado3} formam o triangulo {Triangulos.VerTipoDoTriangulo(lado1,lado2,lado3)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}while (opcao != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro numero");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo numero");
    num2 = int.Parse(Console.ReadLine());
}

void LerTresNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro numero");
    lado1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo numero");
    lado2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o terceiro numero");
    lado3 = int.Parse(Console.ReadLine());
}