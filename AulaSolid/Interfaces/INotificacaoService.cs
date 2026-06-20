using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSolid.Interfaces
{
    public interface INotificacaoService
    {
        void EnviarNotificacao(string destino, string mensagem);
    }
}