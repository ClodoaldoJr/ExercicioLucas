using System;

namespace ExercicioLucas
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            string[] churras = new string[5] {"Lucas", "Tony", "Brandon", "Nicolas","Fuscão" };
            int[] idade = new int[5] { 26, 30, 28, 22, 25 };


            Console.WriteLine("Mulekada");
            for (i = 0; i < churras.Length; i++)
            {
                Console.WriteLine((i + 1) + " . " + churras[i].ToUpper() + " - " + idade[i]);

            }

            Console.ReadLine();
        }
    }
}
