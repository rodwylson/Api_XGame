
using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Service;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Service
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {

        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
            
        }

        public ServiceJogador()
        {

        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador(null,null);
            jogador.Nome = request.Nome;
            jogador.Email = request.Email;
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);
           
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogador é obrigatório!");
            }

            var email = new Email("paulo");

            var jogador = new Jogador(email,"222");

            AddNotifications(jogador);

            if (jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool IsEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
