using AulaSolid.Interfaces;
using AulaSolid.Repositories;
using AulaSolid.Services;

namespace AulaSolid
{
    public class Program
    {
        public static void Main()
        {
            IPedidoRepository repositorio = new PedidoRepository();
            INotificacaoService servicoNotificacao = new EmailService();
            var processador = new ProcessadorPedido(repositorio, servicoNotificacao);

            Console.WriteLine((new string('-', 12) + "SISTEMA DE PROCESSAMENTO DE PEDIDOS:" + new string('-', 12)));

            Console.Write("Digite o nome do cliente: ");
            string cliente = Console.ReadLine();

            Console.Write("Digite o valor total do pedido (ex: 1500,00): ");
            double valorTotal = double.Parse(Console.ReadLine());

            Console.Write("Digite o e-mail de contato: ");
            string contato = Console.ReadLine();

            Console.WriteLine("\nIniciando processamento...");
            Console.WriteLine(new string('-', 60));

            try
            {
                processador.Processar(cliente, valorTotal, contato);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERRO] {ex.Message}");
            }

            Console.WriteLine(new string('-', 60));
            Console.ReadKey();
        }
    }
}
