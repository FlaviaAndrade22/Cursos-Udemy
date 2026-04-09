//using System.ComponentModel.Design;

//namespace Ambiente_para_uso_dos_cursos
//{
//    internal class media
//    {
//        static void Main(string[] args)
//        {
//            double n1, n2, n3, media, nota;
//            string materia;

//            Console.WriteLine("Insira o nome da matéria:");
//            materia = Console.ReadLine();

//            Console.WriteLine($"Insira a media minima para passar na matéria de {materia}:");
//            media = double.Parse(Console.ReadLine());

//            Console.WriteLine("Primeira nota:");
//            n1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("Segunda nota:");
//            n2 = double.Parse(Console.ReadLine());

//            Console.WriteLine("terceira nota:");
//            n3 = double.Parse(Console.ReadLine());

//            nota = (n1 + n2 + n3) / 3;



//            if (nota == media)
//            {
//                Console.WriteLine("Você esta na media");
//            }
//            else if (nota < media)
//            {
//                Console.WriteLine($"Você ficou abaixo da media. nota igual a {nota}");
//            }
//            else if (nota > media)
//            {
//                Console.WriteLine($"Você passou. nota igual a {nota}");
//            }

//            return;
//        }
//    }
//}