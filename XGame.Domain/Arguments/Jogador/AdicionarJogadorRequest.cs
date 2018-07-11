﻿using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string UltimoNome { get; set; }
        public string PrimeiroNome { get; set; }
    }
}
