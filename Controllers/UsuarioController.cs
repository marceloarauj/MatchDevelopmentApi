using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchDevelopment.Auxiliares;
using MatchDevelopment.DTO;
using MatchDevelopment.Inputs;
using MatchDevelopment.Services.SessaoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchDevelopment.Controllers
{
    [Route("usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IInjecaoDependencia Injetavel;
        public readonly ISessao sessao;
        public UsuarioController(IInjecaoDependencia injetavel, ISessao sessao)
        {
            this.Injetavel = injetavel;
            this.sessao = sessao;
        }


        [HttpPost("login")]
        public ActionResult<UsuarioDTO> EfetuarLogin([FromBody] DadosLogin dados)
        {
            UsuarioDTO usuario = null;

            dados.Senha = Cript.obterSenhaCriptografada(dados.Senha);
            usuario = Injetavel.FazerLogin(dados);

            if(usuario == null)
                return BadRequest("Login ou senha incorretos");

            return usuario;
        }

        [HttpPost("registrar")]
        public ActionResult RegistrarUsuario([FromBody] DadosRegistrar dados)
        {
            dados.Senha = Cript.obterSenhaCriptografada(dados.Senha);
            bool usuarioCadastrado = Injetavel.FazerRegistro(dados);

            if(usuarioCadastrado)
                return Ok("Usuário cadastrado com sucesso!");
            
            return BadRequest("Login de usuário já existe");
        }
    }
}