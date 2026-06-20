using AulaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSolid.Services
{
    public class WhatsAppService : INotificacaoService
    {
        public void EnviarNotificacao(string destino, string mensagem)
        {
            Console.WriteLine($"[WhatsApp] Enviando mensagem para o número {destino}: {mensagem}");
        }
    }
}
