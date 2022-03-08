using System;

namespace OrientacaoObjeto8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Oleo volumeoleo = new Oleo();
            volumeoleo.raio = 3.5;
            volumeoleo.altura = 8;
            Console.WriteLine($"A sua lata de oleo tem {volumeoleo.volume():F2} metros cubicos");
            Console.ReadKey();
        }
    }
}
