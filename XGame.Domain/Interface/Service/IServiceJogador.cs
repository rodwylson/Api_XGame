using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Interface.Service
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
            
    }
}
