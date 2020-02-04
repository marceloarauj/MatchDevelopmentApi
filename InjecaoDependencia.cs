using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchDevelopment.Contexts;
using MatchDevelopment.DTO;
using MatchDevelopment.Inputs;
using MatchDevelopment.Models;
using MatchDevelopment.Services.SessaoService;

namespace MatchDevelopment
{
    public class InjecaoDependencia : IInjecaoDependencia
    {
        private readonly ISessao sessao;
        public InjecaoDependencia(ISessao sessao){
            this.sessao = sessao;
        }
        private UsuarioContexto UsuarioContext;

        public UsuarioDTO FazerLogin(DadosLogin dados)
        {
            this.UsuarioContext = new UsuarioContexto();
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            
            Usuario usuario = this.UsuarioContext.Usuarios.Where(
                u => u.login_usuario == dados.Login && u.senha_usuario == dados.Senha
                    ).FirstOrDefault();

            if(usuario != null){
                usuarioDTO.Nome = usuario.nome_usuario;
                usuarioDTO.Email = usuario.email_usuario;
                usuarioDTO.Avaliacao = usuario.avaliacao_usuario;
                
                sessao.RegistrarUsuarioNaSessao(usuarioDTO);
                return usuarioDTO;
            }

            return null;
        }

        public bool FazerRegistro(DadosRegistrar dados)
        {
            this.UsuarioContext = new UsuarioContexto();
            Usuario Usuario = new Usuario();

            Usuario.nome_usuario = dados.NomeUsuario;
            Usuario.login_usuario = dados.Login;
            Usuario.senha_usuario = dados.Senha;
            Usuario.email_usuario = dados.Email;

            var usuarioExiste = 
                UsuarioContext.Usuarios.FirstOrDefault(e => e.login_usuario == Usuario.login_usuario);

            if(usuarioExiste != null)
                return false;

            UsuarioContext.Set<Usuario>().Add(Usuario);
            UsuarioContext.SaveChanges();

            return true;
        }
    }
}
