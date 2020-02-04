using Microsoft.AspNetCore.SignalR;

namespace MatchDevelopment.Services.ChatService
{
    public class ChatGlobalHub:Hub
    {
        public void MensagemGlobal(string usuario,string mensagem){
            Clients.All.SendAsync("mensagemGlobal",usuario,mensagem);
        }
    }
}