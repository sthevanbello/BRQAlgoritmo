using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista06
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

            //Exercicio09();

            //Exercicio10();

            Console.ReadKey();
        }
        private static void Exercicio01()
        {
            Console.WriteLine("Lista 06 - Exercício 01\n");

            double[] vetor = new double[8];

            for (int i = 0; i < vetor.Length; i++)
            {
                //vetor[i] = i*i*i;
                vetor[i] = Math.Pow(i, 3);
            }
            #region ForEach
            //foreach (var item in vetor)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Posição do vetor, índice {i}, elevado ao cubo: {vetor[i]}");
            }
            Espacos();
        }
        private static void Exercicio02()
        {
            Console.WriteLine("Lista 06 - Exercício 02\n");
            int[] vetor = { 5, 1, 4, 2, 7, 8, 3, 6 };
            int[] vetor2 = new int[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor2[i] = vetor[i] * 2;
            }

            #region ForEach
            //foreach (var numero in vetor2)
            //{
            //    Console.WriteLine($"{numero}");
            //}
            #endregion

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Vetor 1 posição {i}: {vetor[i]} =+=+= Vetor 2 posição {i} : {vetor2[i]} dobro de {vetor[i]}");
            }
            Espacos();
        }
        private static void Exercicio03()
        {
            Console.WriteLine("Lista 06 - Exercício 03\n");
            double[] vetorA = new double[10];
            double[] vetorM = new double[10];
            double multiplicadorX = 0;

            for (int i = 0; i < vetorA.Length; i++)
            {
                #region TryParse
                //int res = 0;
                //int.TryParse(Console.ReadLine(), out res);
                //vetorA[i] = res;
                #endregion

                Console.Write($"Insira o valor {i + 1}: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Insira o valor para multiplicar cada elemento: ");
            multiplicadorX = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetorM.Length; i++)
            {
                vetorM[i] = vetorA[i] * multiplicadorX;
                Console.WriteLine($"{vetorA[i]} x {multiplicadorX} = {vetorM[i]}");
            }
            Espacos();

            #region ForEach
            //foreach (var numero in vetorM)
            //{
            //    Console.WriteLine(numero);
            //}
            #endregion

            #region For Apenas para imprimir VetorM
            //for (int i = 0; i < vetorM.Length; i++)
            //{
            //    Console.WriteLine($"{vetorA[i]} x {multiplicadorX} = {vetorM[i]}");
            //}
            #endregion
        }
        private static void Exercicio04()
        {
            Console.WriteLine("Lista 06 - Exercício 04\n");
            string[] nomes = new string[5];
            bool achou = false;
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
            Console.Write("Insira o nome para buscar: ");
            string nomeParaBuscar = Console.ReadLine();

            foreach (var nome in nomes)
            {
                if (nomeParaBuscar == nome)
                {
                    achou = true;
                    break;
                }
                achou = false;

            }
            if (achou)
            {
                Console.WriteLine("ACHEI");
            }
            else
            {
                Console.WriteLine("NÃO ACHEI");
            }
            Espacos();
        }
        private static void Exercicio05()
        {
            Console.WriteLine("Lista 06 - Exercício 05\n");
            int[] vetorQ = new int[10];
            List<int> lista = new List<int>();
            int contador = 0;
            int posicao = 0;
            int maior = -9999999;
            while (true)
            {
                if (contador > 9)
                    break;

                Console.Write($"Posição {contador} no vetor - Insira um número par: ");
                int numeroLido = int.Parse(Console.ReadLine());

                if (numeroLido % 2 == 0)
                {
                    vetorQ[contador] = numeroLido;
                    contador++;
                    lista.Add(numeroLido);
                }
                else
                    Console.WriteLine("Insira números pares, apenas");
            }

            for (int i = 0; i < vetorQ.Length; i++)
            {
                if (vetorQ[i] > maior)
                {
                    maior = vetorQ[i];
                    posicao = i;
                }
            }

            Console.WriteLine($"Maior número inserido: {maior} --- Posição no vetor: {posicao}");

            #region Usando List
            var maior2 = lista.Max();
            var maiores = lista.Where(x => x == maior2).ToList();
            var indices = lista.Select((num, indice) => new { num, indice })
                  .Where(x => x.num == maior2)
                  .Select(x => x.indice).ToList();

            for (int i = 0; i < maiores.Count; i++)
            {
                Console.WriteLine($"Maior número inserido: {maiores[i]} --- Posição no vetor: {indices[i]}");
            }
            #endregion

            Espacos();
        }
        private static void Exercicio06()
        {
            Console.WriteLine("Lista 06 - Exercício 06\n");
            double[] temperaturas = new double[7];
            double soma = 0, media = 0, menorTemperatura = 100, maiorTemperatura = 0;
            int diasAbaixoDaMedia = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Temperatura no dia {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > maiorTemperatura)
                    maiorTemperatura = temperaturas[i];
                if (temperaturas[i] < menorTemperatura)
                    menorTemperatura = temperaturas[i];
                soma += temperaturas[i];
            }

            media = soma / temperaturas.Length;

            foreach (var temperaturaDia in temperaturas)
            {
                if (temperaturaDia < media)
                    diasAbaixoDaMedia++;
            }
            Console.WriteLine($"Menor temperatura da semana: {menorTemperatura}");
            Console.WriteLine($"Maior temperatura da semana: {maiorTemperatura}");
            Console.WriteLine($"Média semanal: {media.ToString("N2")}");
            Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoDaMedia}");

            Espacos();
        }
        private static void Exercicio07()
        {
            Console.WriteLine("Lista 06 - Exercício 07\n");

            double[] vetor = new double[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Insira o valor {i + 1}: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            //Array.Sort(vetor);

            //Ordenar(vetor, vetor.Length);

            #region Bubble Sort

            for (int i = vetor.Length; i > 1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        double auxiliar = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = auxiliar;
                    }
                }
            }

            #endregion

            #region Bublle Sort com funções

            //Ordenar(vetor, vetor.Length);

            //void Ordenar(double[] vetor, int tamanho)
            //{
            //    for (int i = tamanho; i > 1; i--)
            //    {
            //        movimentaValor(vetor, i);
            //    }
            //}

            //void movimentaValor(double[] vetor, int tamanho)
            //{
            //    for (int i = 0; i < tamanho - 1; i++)
            //    {
            //        if (vetor[i] > vetor[i + 1])
            //        {
            //            TrocadePosicao(vetor, i);
            //        }
            //    }
            //}

            //void TrocadePosicao(double[] vetor, int i)
            //{
            //    double auxiliar = vetor[i];
            //    vetor[i] = vetor[i + 1];
            //    vetor[i + 1] = auxiliar;
            //}
            #endregion

            foreach (var numero in vetor)
            {
                Console.WriteLine(numero);
            }

            Espacos();
        }
        private static void Exercicio08()
        {
            Console.WriteLine("Lista 06 - Exercício 08\n");
            double num1 = 0, num2 = 0, num3 = 0;

            Console.WriteLine("Digite três valores");

            Console.Write("Digite o valor 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor 3: ");
            num3 = double.Parse(Console.ReadLine());

            double soma = Soma(num1, num2, num3);
            
            double media = Media(soma);

            double media2 = Media2(num1, num2, num3);

            double Soma(double num1, double num2, double num3)
            {
                return num1 + num2 + num3;
            }

            double Media(double soma)
            {
                return soma / 3;
            }

            double Media2(double num1, double num2, double num3)
            {
                double soma = Soma(num1, num2, num3);

                return soma / 3;
            }

            Console.WriteLine($"Soma: {soma:0.00}\nMédia: {media2:0.00}");

            Espacos();
        }
        private static void Exercicio09()
        {
            Console.WriteLine("Lista 06 - Exercício 09\n");

            double numero = double.Parse(Console.ReadLine());

            string resultado = VerificaNumero(numero);

            Console.WriteLine(resultado);



            string VerificaNumero(double numero)
            {
                if (numero > 0)
                {
                    return "P";
                }
                return "N";
            }

            Espacos();
        }
        private static void Exercicio10()
        {
            Console.WriteLine("Lista 06 - Exercício 10\n");

            var numero = Convert.ToInt32(Console.ReadLine());

            string numeroTexto = numero.ToString();

            Console.WriteLine($"\nO número {numeroTexto} possui {numeroTexto.Length} dígitos");

            Espacos();
        }

        public static void Espacos()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=+");
            }
            Console.ForegroundColor = color;
            Console.WriteLine();
        }
    }
}
