using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Service;

namespace XGameAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carregando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instância do serviço");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instância do meu objeto request");

            request.Email = "rode@gmailcom";

            var response = service.AutenticarJogador(request);

            //if (service.IsValid)
            //{
            //    return response;
            //}

            
            Console.ReadKey();
        }
    }
}
