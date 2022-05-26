﻿using System;

namespace Lista02
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

            Exercicio06();

            Console.ReadKey();
        }
        private static void Exercicio01()
        {
            Console.WriteLine("Lista 02 - Exercício 01\n");
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
            Console.WriteLine("Lista 02 - Exercício 02\n");
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
            Console.WriteLine("Lista 02 - Exercício 03\n");
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
            Console.WriteLine("Lista 02 - Exercício 04\n");
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
            Console.WriteLine("Lista 02 - Exercício 05\n");
            int[] vetorQ = new int[10];
            int contador = 0;
            int posicao = 0;
            int maior = 0;
            while (true)
            {
                if (contador > 9) break;

                Console.Write($"Posição {contador} no vetor - Insira um número par: ");
                int numeroLido = int.Parse(Console.ReadLine());

                if (numeroLido % 2 == 0)
                {
                    vetorQ[contador] = numeroLido;
                    contador++;
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
            Espacos();
        }
        private static void Exercicio06()
        {
            Console.WriteLine("Lista 02 - Exercício 06\n");
            double[] temperaturas = new double[7];
            double soma = 0, media = 0, menorTemperatura = 100, maiorTemperatura = 0;
            int diasAbaixoDaMedia = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Temperatura no dia {i+1}: ");
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
                if(temperaturaDia < media)
                    diasAbaixoDaMedia++;
            }
            Console.WriteLine($"Menor temperatura da semana: {menorTemperatura}");
            Console.WriteLine($"Maior temperatura da semana: {maiorTemperatura}");
            Console.WriteLine($"Média semanal: {media.ToString("N2")}");
            Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoDaMedia}");

            Espacos();
        }
        public static void Espacos()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}