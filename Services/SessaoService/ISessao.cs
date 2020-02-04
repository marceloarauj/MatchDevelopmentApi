using MatchDevelopment.DTO;

namespace MatchDevelopment.Services.SessaoService
{
    public interface ISessao
    {
         void RegistrarUsuarioNaSessao(UsuarioDTO usuarioObject);
         UsuarioDTO ObterUsuario();
         void RemoverRegistro();
         bool EhAdmin();

    }
}