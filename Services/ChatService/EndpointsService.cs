using Microsoft.AspNetCore.Builder;

namespace MatchDevelopment.Services.ChatService
{
    public class EndpointsService
    {
        public static void RegistrarEndpoints(IApplicationBuilder app){

            app.UseSignalR(rotas =>{
                rotas.MapHub<ChatGlobalHub>("/WSglobal");
                rotas.MapHub<ChatPrivado>("/WSprivado");
                rotas.MapHub<ChatGrupo>("/WSgrupo");
            });
        }
    }
}