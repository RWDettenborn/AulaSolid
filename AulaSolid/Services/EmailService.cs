using AulaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSolid.Services
{
    public class EmailService : INotificacaoService
    {
        public void EnviarNotificacao(string destino, string mensagem)
        {
            Console.WriteLine($"[E-mail] Enviando mensagem para {destino}: {mensagem}");
        }
    }
}
