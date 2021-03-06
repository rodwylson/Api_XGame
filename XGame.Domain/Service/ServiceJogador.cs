﻿
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Service;
using XGame.Domain.Resources;
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
            var nome = new Nome(request.PrimeiroNome,request.UltimoNome);
            var email = new Email(request.Email);


            Jogador jogador = new Jogador(nome,email,request.Senha );

            if (IsInvalid())
            {
                return null;
            }

            Guid id = _repositoryJogador.AdicionarJogador(jogador);
           
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
            }
            
            var email = new Email(request.Email);
            var jogador = new Jogador(email,request.Senha);

            AddNotifications(jogador,email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            //var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);
            

           // return response;
            return null;
        }

        private bool IsEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
