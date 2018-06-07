using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdicionarJogador(AdicionarJogadorRequest request);

    }
}
