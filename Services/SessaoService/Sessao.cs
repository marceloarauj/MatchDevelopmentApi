using MatchDevelopment.DTO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MatchDevelopment.Services.SessaoService
{
    public class Sessao: ISessao
    {
        private readonly IHttpContextAccessor DadosDaSessao;

        public Sessao(IHttpContextAccessor DadosDaSessao){
            this.DadosDaSessao = DadosDaSessao;
        }

        public void RegistrarUsuarioNaSessao(UsuarioDTO usuarioObject){

            string usuario = JsonConvert.SerializeObject(usuarioObject);
            DadosDaSessao.HttpContext.Session.SetString("usuario",usuario);
        }

        public void RemoverRegistro(){
            UsuarioDTO usuario = ObterUsuario();

            if(usuario != null)
                DadosDaSessao.HttpContext.Session.Remove("usuario");

        }
        public UsuarioDTO ObterUsuario(){

            string usuario = DadosDaSessao.HttpContext.Session.GetString("usuario");
            UsuarioDTO usuarioObject = JsonConvert.DeserializeObject<UsuarioDTO>(usuario);

            return usuarioObject;
        }

        public bool EhAdmin(){

            if(ObterUsuario() != null & ObterUsuario().EhAdmin)
                return true;
            
            return false;
        }
    }
}