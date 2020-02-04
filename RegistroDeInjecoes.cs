
using MatchDevelopment.Services.SessaoService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MatchDevelopment
{
    class RegistroDeInjecoes{

        public static void RegistrarInjecoes(IServiceCollection services){

            //Injecao para o primeiro passo no serviço de login
            services.AddSingleton<IInjecaoDependencia,InjecaoDependencia>();
            
            //outras injeções
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ISessao,Sessao>();
        }
    }
}