using AulaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSolid
{
    public class ProcessadorPedido
    {
        private readonly IPedidoRepository _repository;
        private readonly INotificacaoService _notificacao;
        public ProcessadorPedido(IPedidoRepository repository, INotificacaoService notificacao)
        {
            _repository = repository;
            _notificacao = notificacao;
        }

        public void Processar(string cliente, double valorTotal, string contatoCliente)
        {
            if (valorTotal <= 0)
            {
                throw new ArgumentException("Valor do pedido inválido.");
            }

            double valorFinal = AplicarDesconto(valorTotal);

            _repository.Salvar(cliente, valorFinal);
            _notificacao.EnviarNotificacao(contatoCliente, "Seu pedido foi processado com sucesso!");
        }

        private double AplicarDesconto(double valor)
        {
            if (valor > 1000)
            {
                return valor - 100;
            }
            return valor;
        }
    }
}