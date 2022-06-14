using System;
using System.Globalization;

namespace Lista04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            Exercicio08();
        }
        private static void Exercicio01()
        {
            // X = A + B / C
            Console.WriteLine("Lista 04 - Exercício 01\n");
            double[] numeros = new double[3];
            Console.WriteLine("Insira três números");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} - Insira um número: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
            double resultado = numeros[0] + numeros[1] / numeros[2];
            Console.WriteLine(resultado);
            Espacos();
        }
        private static void Exercicio02()
        {
            Console.WriteLine("Lista 04 - Exercício 02\n");

            double[] notas = new double[3];
            //int peso1 = 2, peso2 = 3, peso3 = 5;
            Console.Write("Insira o peso 1: ");
            int peso1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o peso 2: ");
            int peso2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o peso 3: ");
            int peso3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite as três notas do aluno");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            var resultado = (notas[0] * peso1 + notas[1] * peso2 + notas[2] * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine($"A média ponderada do aluno é: {resultado:0.00}");

            Espacos();
        }
        private static void Exercicio03()
        {
            Console.WriteLine("Lista 04 - Exercício 03\n");
            int horas = 0, minutos = 0, segundos = 0;

            Console.WriteLine("Insira o tempo de duração do evento em segundos");
            int tempoEmSegundos = int.Parse(Console.ReadLine());
            #region Com if

            if (tempoEmSegundos >= 3600)
                horas = tempoEmSegundos / 3600;
            if (tempoEmSegundos % 3600 >= 60)
                minutos = (tempoEmSegundos % 3600) / 60;
            if (tempoEmSegundos % 3600 % 60 > 0)
                segundos = tempoEmSegundos % 3600 % 60;
            #endregion

            Console.WriteLine($"{horas}:{minutos}:{segundos}\n");

            #region Sem if
            int horas2 = (tempoEmSegundos / (60 * 60));
            int minutos2 = ((tempoEmSegundos - (horas2 * 3600)) / 60);
            int segundos2 = (tempoEmSegundos - (horas2 * 3600) - (minutos2 * 60));

            Console.WriteLine($"{horas2:00} h");
            Console.WriteLine($"{minutos2:00} min");
            Console.WriteLine($"{segundos2:00} seg");

            int horas3 = tempoEmSegundos / 3600;
            int minutos3 = (tempoEmSegundos % 3600) / 60;
            int segundos3 = (tempoEmSegundos % 3600) % 60;

            Console.WriteLine($"{horas3:00} h");
            Console.WriteLine($"{minutos3:00} min");
            Console.WriteLine($"{segundos3:00} seg");

            Console.WriteLine(horas.ToString("D") + " horas");
            #endregion

            Espacos();
        }
        private static void Exercicio04()
        {
            Console.WriteLine("Lista 04 - Exercício 04\n");

            //((lado * lado) * sqrt(3)) / 4
            double area = 0, lado = 0;

            Console.Write("Digite o valor dos lados do triângulo equilátero: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado * Math.Sqrt(3) / 4;

            Console.WriteLine($"Área do triângulo equilátero: {area:0.00}m²");

            Espacos();
        }
        private static void Exercicio05()
        {
            Console.WriteLine("Lista 04 - Exercício 05\n");
            int[] valores = new int[3];

            Console.WriteLine("Digite três valores inteiros e positivos");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            double resultado = Math.Pow((valores[0] + valores[1]), 2) + valores[2];
            //double resultado = ((valores[0] + valores[1])^2 + valores[2]);

            Console.WriteLine($"Resultado: {resultado}");

            Espacos();
        }
        private static void Exercicio06()
        {
            Console.WriteLine("Lista 04 - Exercício 06\n");

            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            //double dobrodoAntecessor = Math.Pow(valor - 1, 2);
            double dobrodoAntecessor = (valor - 1) * (valor - 1);

            Console.WriteLine($"Dobro do seu antecessor: {dobrodoAntecessor}");
            Espacos();
        }
        private static void Exercicio07()
        {
            Console.WriteLine("Lista 04 - Exercício 07\n");

            Console.Write($"Insira o total de eleitores da cidade: ");
            double eleitores = double.Parse(Console.ReadLine());

            Console.Write($"Insira o total de votos em branco: ");
            double brancos = double.Parse(Console.ReadLine());

            Console.Write($"Insira o total de votos nulos: ");
            double nulos = double.Parse(Console.ReadLine());

            Console.Write($"Insira o total de votos válidos: ");
            double validos = double.Parse(Console.ReadLine());

            double percentualBrancos = Math.Round(brancos / eleitores * 100, 2);
            double percentualNulos = nulos / eleitores * 100;
            double percentualValidos = validos / eleitores * 100;

            Console.WriteLine($"Eleitores: {eleitores}");
            Console.WriteLine($"Votos em Branco: {brancos} - Percentual em relação aos eleitores: {percentualBrancos}%");
            Console.WriteLine($"Votos Nulos: {nulos} - Percentual em relação aos eleitores: {percentualNulos:0.00}%");
            Console.WriteLine($"Votos válidos: {validos} - Percentual em relação aos eleitores: {percentualValidos.ToString("G")}%");

            Espacos();
        }
        private static void Exercicio08()
        {
            Console.WriteLine("Lista 04 - Exercício 08\n");

            double percentagemDistribuidor = 0.3, percentagemImpostos = 0.45, custoConsumidor = 0;

            Console.Write("Insira o custo de fábrica do veículo: ");
            double custoFabrica = double.Parse(Console.ReadLine());

            double valorDistribuidor = percentagemDistribuidor * custoFabrica;
            double custoImposto = percentagemImpostos * custoFabrica;

            custoConsumidor = custoFabrica + valorDistribuidor + custoImposto;

            Console.WriteLine($"Custo de impostos: {custoImposto.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}");
            Console.WriteLine($"Custo do distribuidor: {valorDistribuidor.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}");
            Console.WriteLine($"Custo ao consumidor: {custoConsumidor.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}");

            Espacos();
        }
        private static void Espacos()
        {
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
