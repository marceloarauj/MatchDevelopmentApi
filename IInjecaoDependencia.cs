using MatchDevelopment.DTO;
using MatchDevelopment.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchDevelopment
{
    public interface IInjecaoDependencia
    {
        UsuarioDTO FazerLogin(DadosLogin dados);
        bool FazerRegistro(DadosRegistrar dados);

    }
}
