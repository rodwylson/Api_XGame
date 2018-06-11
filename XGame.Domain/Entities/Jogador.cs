using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Entities
{
    public class Jogador:Notifiable
    {
        new AddNotifications<Jogador>(this).
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;
        }
       
        public Guid Id { get; set; }

        public Nome Nome { get; set; }        

        public Email Email { get; set; }

        public string Senha { get; private set; }

        public EnumSituacaoJogador Status { get; set; }

    }
}
