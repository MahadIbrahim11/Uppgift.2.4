using System;
namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("har gått ut gymmnasiet");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder <22)

            {
                Console.WriteLine("vi vill gärna anställa dig");
            }
              else if (ålder >25)
            {
                Console.WriteLine("vi letar tyvärr efter annan personal just nu");

            }
            else
            {
                Console.WriteLine("vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}
