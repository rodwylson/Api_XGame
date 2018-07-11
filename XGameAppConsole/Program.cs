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

            var request = new AdicionarJogadorRequest()
            {
                Email = "rode@gmailcom",
                PrimeiroNome  = "Rodwylson",
                UltimoNome  = "Rodwylson",
                Senha = "123"
        };

               
            Console.WriteLine("Criei instância do meu objeto request");
           /* request.Email = "rode@gmailcom";
            request.Senha = "123456";
             */           
            var response = service.AdicionarJogador(request);

            //if (service.IsValid)
            //{
            //    return response;
            //}

            
            Console.ReadKey();
        }
    }
}
