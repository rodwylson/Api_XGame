using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Interface.Service
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
            
    }
}
