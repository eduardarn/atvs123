using System;

namespace ex3
{
    class Program
    {

        static void Main(string[] args)
        {
            int salario;
            Console.WriteLine("Digite seu salário");
            salario = Convert.ToInt16(Console.ReadLine());
            string genero;
            Console.WriteLine("Informe seu genero");
            genero = Console.ReadLine();

            if (salario <= 1100)
            {
                double v = 0.075 * salario;
                double g = salario - v;
                Console.WriteLine($"Seu salario com o desconto do INSS é {g} reais");
            }

            else if (salario >= 1100.01 && salario <= 2003.48)
            {
                double h = 0.09 * salario;
                double i = salario - h;
                Console.WriteLine($"Seu salario com o desconto do INSS é {i} reais");

            }

            else if (salario >= 2203.49 && salario <= 3305.22)
            {
                double f = 0.12 * salario;
                double u = salario - f;
                Console.WriteLine($"Seu salario com o desconto do INSS é {u} reais");

            }

            else if (salario >= 3305.23 && salario <= 6433.57)
            {
                double r = 0.14 * salario;
                double p = salario - r;
                Console.WriteLine($"Seu salario com o desconto do INSS é {p} reais");

            }

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
