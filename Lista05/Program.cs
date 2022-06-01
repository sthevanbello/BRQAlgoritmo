using System;

namespace Lista05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio02();
        }

        private static void Exercicio02()
        {
            #region Letra C
            bool a, b, c;

            Console.WriteLine((a = true) || (b = true) && (c = true));
            Console.WriteLine((a = true) || (b = true) && (c = false));
            Console.WriteLine((a = true) || (b = false) && (c = false));
            Console.WriteLine((a = true) || (b = false) && (c = true));
            #endregion
        }
    }
}
