using System;

namespace CursoAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condicional encadeada e composta
            //Repeticao();
            #endregion

            #region Estruturas de repetição
            //While();
            //DoWhile();
            //ForEach();
            //For();
            #endregion


            int soma = Somar(5, 6);
            Console.WriteLine(soma);

            int Somar(int numero1, int numero2)
            {
                return numero1 + numero2;
            }

            Console.WriteLine(Dividir(5, 6));
            try
            {
                Console.WriteLine(Dividir(0, 5));
                Console.WriteLine(Dividir(5, 0));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Console.ReadKey();
        }

        public static void For()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void ForEach()
        {
            string[] livros = { "Senhor dos Aneis - A sociedade do Anel", "Harry Potter e o prisioneiro de Azkaban", "Fundação" };
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }

        public static void DoWhile()
        {
            Console.Write("Enter your name: ");
            string nomeUsuario = Console.ReadLine();
            do
            {
                nomeUsuario = Console.ReadLine();
                Console.WriteLine("Loop - Do While");
            } while (nomeUsuario == "Sthevan");
        }

        public static void While()
        {
            Console.Write("Enter your name: ");
            string nomeUsuario = Console.ReadLine();

            while (nomeUsuario != "sthevan")
            {
                Console.WriteLine("Please, enter an valid user name: ");
                Console.Write("Enter your name: ");
                nomeUsuario = Console.ReadLine();
            }
            Console.WriteLine("Fim do while");
        }

        public static void Repeticao()
        {
            int idade = 19;
            bool aprovado = true;

            Console.WriteLine("Curso EduSync - BRQ");
            if (idade >= 18)
            {
                Console.WriteLine("Pode tentar tirar a carteira de motorista");
                if (aprovado)
                {
                    Console.WriteLine("Parabéns, você está habilitado!");
                }
                else
                {
                    Console.WriteLine("Sinto muito, tente novamente");
                }
            }
            else if (idade < 18 && idade > 16)
            {
                Console.WriteLine("Você ainda não pode tentar tirar a habilitação de motorista, tente quando estiver com 18 anos");
            }
            else
            {
                Console.WriteLine("Você pode guardar dinheiro para tentar tirar a habilitação de motorista quando estiver com 18 anos");
            }
        }

        public static float Dividir(float numero1, float numero2)
        {
            if (numero1 == 0 || numero2 == 0)
            {
                throw new Exception("Não pode dividir por zero");
            }
            else
            {
                return numero1 / numero2;
            }

        }
    }
}
