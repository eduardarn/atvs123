using System;

namespace ex2
{
    class Program

    {
        static void Main(string[] args)
        {
            string genero;
            Console.WriteLine("Informe seu genero");
            genero = Console.ReadLine();

            if (genero == "masculino")
            {
                Console.WriteLine("Se direcione para a fila da direita");
            }

            else if (genero == "feminino")
            {
                Console.WriteLine("Se direcione para a fila da esquerda");
            }

            else
            {
                Console.WriteLine("Genero incorreto!");
            }
        }
    }
}
