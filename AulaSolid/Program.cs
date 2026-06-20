namespace AulaSolid
{
    public class ProcessadorPedido
    {
        public void Processar(string cliente, double valorTotal, string emailCliente)
        {
            // 1. Validação do pedido
            if (valorTotal <= 0)
            {
                throw new ArgumentException("Valor do pedido inválido.");
            }

            // 2. Aplicação de desconto (Regra de negócio)
            if (valorTotal > 1000)
            {
                valorTotal -= 100; // Desconto VIP
            }

            // 3. Simulação de salvar no Banco de Dados
            Console.WriteLine($"Salvando pedido de {cliente} no valor de R${valorTotal} no Banco de Dados...");

            // 4. Envio de E-mail de confirmação
            Console.WriteLine($"Enviando e-mail para {emailCliente}: Seu pedido foi processado com sucesso!");
        }
    }

    // Exemplo teste de execução
    public class Program
    {
        public static void Main()
        {
            var processador = new ProcessadorPedido();
            processador.Processar("Robert William", 1500, "robert@gmail.com");
        }
    }
}
