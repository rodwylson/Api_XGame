using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Service;

namespace XGame.Domain.Service
{
    public class ServiceJogador : IServiceJogador
    {

        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
            
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
           Guid id = _repositoryJogador.AdicionarJogador(request);
           
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
