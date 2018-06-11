using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
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

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um e-mail!");
            }

            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um e-mail!");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe um senha!");
            }
            
            if (request.Senha.Length < 6)
            {
                throw new Exception("Dígite uma senha de no mínimo 6 caracteres!");
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
