using System;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0) 
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }
            //for
            for(var indice = 0; indice < args.Length; indice++) 
            {
            Console.WriteLine($"Estrutura for, indice e valor: {indice}, {args[indice]}");
            }
            //while
            var argsLidos = 0;
            while(argsLidos < args.Length) 
            {
                Console.WriteLine($"Estrutura while, argsLidos e valor lido: {argsLidos}, {args[argsLidos]}");
                argsLidos++;
            }
            //do while
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, loopsEfetuado:{loopsEfetuados}, valor lido:{args[loopsEfetuados]}");
                loopsEfetuados++;
            }
            while (loopsEfetuados < args.Length);

            //foreach
            foreach (var arg in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido: {arg}");
            }
        }
    }
}