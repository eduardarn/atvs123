using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            Console.WriteLine("Digite sua idade");
            idade = Convert.ToInt16(Console.ReadLine());


         { 

            if (idade >= 18)
            {
                Console.WriteLine("Você tem idade para dirigir");
            }


            else
            {
                Console.WriteLine("Você não tem idade para dirigir");
            }


           }

        }
    }
}
