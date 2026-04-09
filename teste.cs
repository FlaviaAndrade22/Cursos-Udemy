//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Ambiente_para_uso_dos_cursos
//{
//    internal class teste
//    {
//        public static void Main(string[] args)
//        {

//            double peso1, altura, imc;

//            Console.WriteLine("Insira seu peso:");
//            peso1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("Insira sua altura:");
//            altura = double.Parse(Console.ReadLine());

//            imc = peso1 / (altura * altura);

//            if (imc < 18.5)
//            {
//                Console.WriteLine($"Você esta abaixo do peso. imc igual a {imc}");
//            }
//            else if (imc >= 18.5 && imc < 25)
//            {
//                Console.WriteLine($"Você esta com o peso normal. imc igual a {imc}");
//            }
//            else if (imc >= 25 && imc < 30)
//            {
//                Console.WriteLine($"Você esta com sobrepeso. imc igual a {imc}");
//            }
//            else if (imc >= 30 && imc < 35)
//            {
//                Console.WriteLine($"Você esta com obesidade grau 1. imc igual a {imc}");
//            }
//            else if (imc >= 35 && imc < 40)
//            {
//                Console.WriteLine($"Você esta com obesidade grau 2. imc igual a {imc}");
//            }
//            else if (imc >= 40)
//            {
//                Console.WriteLine($"Você esta com obesidade morbida. imc igual a {imc}");
//            }

//            return;
//        }

//    }
//}
