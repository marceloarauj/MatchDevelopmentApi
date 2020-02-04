using Microsoft.AspNetCore.SignalR;

namespace MatchDevelopment.Services.ChatService
{
    public class ChatPrivado:Hub
    {
        public void MensagemPrivada(string usuario, string mensagem, string destinarioId){
            Clients.Client(destinarioId).SendAsync("mensagemPrivada",usuario,mensagem); 
        }
    }
}