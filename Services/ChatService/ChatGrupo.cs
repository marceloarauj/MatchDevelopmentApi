using Microsoft.AspNetCore.SignalR;

namespace MatchDevelopment.Services.ChatService
{
    public class ChatGrupo:Hub
    {
        public void MensagemGrupo(string usuario, string mensagem,string grupo){
            Clients.Group(grupo).SendAsync("mensagemGrupo",usuario,mensagem);
        }
    }
}