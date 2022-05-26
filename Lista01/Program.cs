using System;

namespace Lista01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExercicioA();
            Espacos();
            ExercicioB();
            Espacos();
            ExercicioC();
            Espacos();
            ExercicioD();
            Espacos();
            ExercicioE();
            Espacos();
            ExercicioF();

            Console.ReadKey();
        }


        private static void ExercicioA()
        {
            Console.WriteLine("Lista 01 - Exercício A\n");

            int x = 15;
            int y = 20;

            Console.WriteLine($"x:{x}");

            int b = 3;

            Console.WriteLine($"x:{x} y:{y}");

        }
        private static void ExercicioB()
        {
            Console.WriteLine("Lista 01 - Exercício B\n");

            int a = 15;
            int b = 3;
            int c = a * b;

            Console.WriteLine($"c:{c}");

            b = 10;
            c = a - b;

            Console.WriteLine($"a:{a} b:{b} c:{c}");
        }

        private static void ExercicioC()
        {
            Console.WriteLine("Lista 01 - Exercício C\n");

            int x = 10;
            int y = 12;
            int z = x;
            y = z;
            x = y;

            Console.WriteLine($"x:{x} y:{y} z:{z}");
        }
        private static void ExercicioD()
        {
            Console.WriteLine("Lista 01 - Exercício D\n");
            int a = 10;
            int b = a + 2;
            a = b + 1;
            b = a + 1;
            Console.WriteLine($"a:{a}");
            a = b + 1;
            Console.WriteLine($"a:{a} b:{b}");
        }

        private static void ExercicioE()
        {
            Console.WriteLine("Lista 01 - Exercício E\n");
            int x = 12;
            int y = x;
            int z = x + y;
            x = 20;
            y = 10;
            Console.WriteLine($"x:{x} y:{y} z:{z}");
        }
        private static void ExercicioF()
        {
            Console.WriteLine("Lista 01 - Exercício F\n");
            int a = 2;
            int b = 3;
            a = a + b;
            int c = a - b;
            Console.WriteLine($"c:{c}");
            b = 5;
            Console.WriteLine($"a:{a} b:{b} c:{c}");
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
