using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// todos os exercicios estão em um mesmo projeto para facilitar 

namespace Ambiente_para_uso_dos_cursos
{
    public class Soma
    {
        public static void Main(string[] args)
        {
            double n1, n2, soma;

            Console.WriteLine("Insira o primeiro numero:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero:");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine($"A soma dos numeros é igual a {soma}");
            return;
        }
    }
    public class troco
    {
        public static void Main(string[] args)
        {

            double Produto, quantidade, valorPago, troco;

            Console.WriteLine("Insira o valor do produto:");
            Produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de produto que o cliente está levando");
            quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor pago pelo cliente:");
            valorPago = double.Parse(Console.ReadLine());

            troco = valorPago - (Produto * quantidade);

            Console.WriteLine($"O valor do troco é igual a {troco}");
            return;
        }
    }
    public class Pagameto
    {
        public static void Main(string[] args)
        {
            string nome;
            double Horas, ValorHora, Salario;

            Console.WriteLine("Insira o nome do funcionario:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a quantidade de horas trabalhadas:");
            Horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora trabalhada:");
            ValorHora = double.Parse(Console.ReadLine());

            Salario = Horas * ValorHora;

            Console.WriteLine($"Nome do funcionario {nome}");

            Console.WriteLine($"Valor da hora trabalhada {ValorHora}");

            Console.WriteLine($"Horas trabalhadas {Horas}");

            Console.WriteLine($"Salario do funcionario {Salario}");
            return;

        }

    }

    public class consumo
    {
        public static void Main(string[] args)
        {
            double distancia, combustivel, consumo;

            Console.WriteLine("Insira a distancia percorrida:");
            distancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira a quantidade de combustivel gasto:");
            combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = distancia / combustivel;

            Console.WriteLine($"O consumo do veiculo é igual a {consumo:f3} km/l");
            return;
        }

    }
    public class medida
    {
        static void Main(string[] args)
        {
            double lA, lB, lC, quadrado, triangulo, trapezio, chose;

            Console.WriteLine("Insira o valor do lado A:");
            lA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor do lado B:");
            lB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor do lado C:");
            lC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            quadrado = lA * 4;

            triangulo = (lA * lB) / 2;

            trapezio = ((lA + lB) * lC) / 2;

            Console.WriteLine("Escolha a figura geometrica que deseja calcular a area ou o perimetro:");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - Trapezio");
            chose = double.Parse(Console.ReadLine());

            if (chose == 1)
            {
                Console.WriteLine($"O perimetro do quadrado é igual a {quadrado:f4}");

            }
            else if (chose == 2)
            {
                Console.WriteLine($"A area do triangulo é igual a {triangulo:f4}");
            }
            else if (chose == 3)
            {
                Console.WriteLine($"A area do trapezio é igual a {trapezio:f4}");
            }
            return;
        }
    }
}
