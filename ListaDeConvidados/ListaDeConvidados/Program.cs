using System;

namespace ListaDeConvidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if(nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o Programa");
                return;
            }
            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não informada para seguir com o programa");
            }

            bool estaconvidado;
            switch (nome)
            {
                case "Daniel":
                    estaconvidado = true;
                    break;
                case "Evandro":
                    estaconvidado = true;
                    break;
                case "Matheus":
                    estaconvidado = true;
                    break;
                case "Ale":
                    estaconvidado = true;
                    break;
                case "Teresa":
                    estaconvidado = true;
                    break;
                case "Gabriel":
                    estaconvidado = true;
                    break;
                case "Cledson":
                    estaconvidado = true;
                    break;
                case "Giuseppe":
                    estaconvidado = true;
                    break;
                default: estaconvidado = false;
                    break;
            }

            if(estaconvidado == true && idade > 18)
            {
                Console.WriteLine("Parabens, seja bem vindo a festa");
            }
            else if(estaconvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidadis, favor verificar com a pessoa que te convidou");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa");
            }
        }
    }
}