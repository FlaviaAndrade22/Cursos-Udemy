namespace Ambiente_para_uso_dos_cursos
{
    internal class media
    {
        static void Main(string[] args)
        {
            double x, y, media;

            Console.WriteLine("Chose the firt number:");
            x = double.Parse (Console.ReadLine());

            Console.WriteLine("Chose the segunt number:");
            y = double.Parse(Console.ReadLine());

            media = (x + y) / 2;

            Console.WriteLine("media is :" + media );

            return;

        }
    }
}
