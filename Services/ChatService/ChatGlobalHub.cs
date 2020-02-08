using Microsoft.AspNetCore.SignalR;

namespace MatchDevelopment.Services.ChatService
{
    public class ChatGlobalHub:Hub
    {
        public void MensagemGlobal(string mensagem){
            Clients.All.SendAsync("MensagemGlobal",mensagem);
        }
    }
}