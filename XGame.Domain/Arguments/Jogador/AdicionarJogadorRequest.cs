﻿using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }
           

        public Email Email { get; set; }

        public string Senha { get; private set; }
    }
}
