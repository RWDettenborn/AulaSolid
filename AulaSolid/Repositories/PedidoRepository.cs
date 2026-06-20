using AulaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSolid.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public void Salvar(string cliente, double valorTotal)
        {
            Console.WriteLine($"[Banco de Dados] Salvando pedido de {cliente} no valor de R${valorTotal}...");
        }
    }
}
