using System;
using System.Reflection;

namespace PessoasCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas();
            Pessoas pessoa2 = new Pessoas();
            Pessoas pessoa3 = new Pessoas();

            pessoa1.Nome = "Gerson";
            pessoa1.Idade = 37;
            pessoa1.Endereço = ">>> Endereço: Rua Lages n°** \nBlumenau";

            pessoa2.Nome = "Marcio";
            pessoa2.Idade = 50;
            pessoa2.Endereço = "Rua das Missões n°** \nBlumenau";

            pessoa3.Nome = "Lucas";
            pessoa3.Idade = 35;
            pessoa3.Endereço = "Rua Dos caçadores n°** \nBlumenau";

            string nomeContato;

            while (true)
            {
                Console.WriteLine("Digite o contato que você procura");
                nomeContato = Console.ReadLine().ToUpper();

                if (nomeContato == "GERSON" || nomeContato == "MARCIO" || nomeContato == "LUCAS")
                {
                    
                }

                else
                {
                    Console.WriteLine("Nome não encontrado, tente novamente");
                }
                switch (nomeContato)
                {
                    case "GERSON":

                        Console.WriteLine($"Endereço: {pessoa1.Endereço}\n Idade: {pessoa1.Idade}");
                        break;

                    case "MARCIO":

                        Console.WriteLine($"Endereço: {pessoa2.Endereço}\n Idade: {pessoa2.Idade}");
                        break;
                    case "LUCAS":
                        Console.WriteLine($"Endereço: {pessoa3.Endereço}\n Idade: {pessoa3.Idade}");
                        break;
                    default: 
                        break;
                }

            }
        }
    }
}
