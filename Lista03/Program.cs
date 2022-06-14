using System;
using System.Globalization;

namespace Lista03
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
            //Exercicio08();
            //Exercicio09();
            Exercicio10();
        }

        private static void Exercicio01()
        {
            Console.WriteLine("Lista 03 - Exercício 01\n");
            double nota1 = 0, nota2 = 0, nota3 = 0, media = 0;
            string resultado = "";

            Console.Write("Digite a nota 1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 6)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine($"Média: {media} Resultado: {resultado}");

            Espacos();
        }
        private static void Exercicio02()
        {
            Console.WriteLine("Lista 03 - Exercício 02\n");
            double[] valores = new double[3];
            double maior = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");

                valores[i] = double.Parse(Console.ReadLine());
            }
            #region usando for
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
            }
            #endregion

            #region Usando if
            //double a = valores[0];
            //double b = valores[1];
            //double c = valores[2];


            //if (a > maior)
            //{
            //    maior = a;
            //}
            //if (b > maior)
            //{
            //    maior = b;
            //}
            //if (c > maior)
            //{
            //    maior = c;
            //}
            #endregion


            Console.WriteLine($"\nO número {maior.ToString("G")} é o maior");

            //Console.WriteLine(maior.ToString("G", CultureInfo.InvariantCulture));

            Espacos();
        }
        private static void Exercicio03()
        {
            Console.WriteLine("Lista 03 - Exercício 03\n");

            int numero1 = 0, numero2 = 0;
            string resultado = "";

            Console.Write("Digite o número 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 2: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
            {
                resultado = "São múltiplos";
            }
            else
            {
                resultado = "Não são múltiplos";
            }

            Console.WriteLine($"Os números digitados {resultado}");
            Espacos();
        }
        private static void Exercicio04()
        {
            Console.WriteLine("Lista 03 - Exercício 04\n");

            double peso = 0;

            Console.Write("Insira a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Insira o seu sexo homem/mulher: ");
            string sexo = Console.ReadLine();

            if (sexo.ToLower() == "homem")
            {
                peso = (72.7 * altura) - 58;
            }
            else if (sexo.ToLower() == "mulher")
            {
                peso = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine ("Não encontrado, digite apenas homem ou mulher");
            }

            Console.WriteLine ($"O seu Peso ideal para a sua altura é: {peso:0.00}");

            Espacos();
        }
        private static void Exercicio05()
        {
            Console.WriteLine("Lista 03 - Exercício 05\n");
            string resultado = "";

            Console.Write("Digite o primeiro número: ");
            double primeiro = double.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double segundo = double.Parse(Console.ReadLine());

            if (primeiro == segundo)
                resultado = "Números iguais";
            else if (primeiro > segundo)
                resultado = "Primeiro é maior";
            else
                resultado = "Segundo é maior";

            Console.WriteLine(resultado);


            Espacos();
        }
        private static void Exercicio06()
        {
            Console.WriteLine("Lista 03 - Exercício 06\n");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Espacos();
        }
        private static void Exercicio07()
        {
            Console.WriteLine("Lista 03 - Exercício 07\n");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} é múltiplo de 5");
                }
            }

            Espacos();
        }
        private static void Exercicio08()
        {
            Console.WriteLine("Lista 03 - Exercício 08\n");

            Console.Write("Digite um valor a partir de 1, não pode digitar zero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} é par");
                }
            }

            Espacos();
        }
        private static void Exercicio09()
        {
            Console.WriteLine("Lista 03 - Exercício 09\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"7 x {i.ToString().PadRight(2)} = {(i * 7).ToString().PadLeft(2)}");
            }

            Espacos();
        }
        private static void Exercicio10()
        {
            Console.WriteLine("Lista 03 - Exercício 10\n");
            int anterior = 0, proximo = 1, auxiliar = 0; ;

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{proximo} ");
                auxiliar = anterior;
                anterior = proximo;
                proximo = anterior + auxiliar;
            }

            #region Recursividade
            Console.WriteLine($"\n\nCom recursividade\n");

            for (int i = 1; i < 16; i++)
            {
                Console.Write($"{fibonacci(i)} ");
            }

            static int fibonacci(int numero)
            {
                if (numero <= 1)
                {
                    return numero;
                }
                else
                {
                    return fibonacci(numero - 1) + fibonacci(numero - 2);
                }
            }
            #endregion
        }

        public static void Espacos()
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
