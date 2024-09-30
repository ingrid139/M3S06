
namespace Aula2.Exercicios
{
    public class Exercicio3
    {
        public void ProcessarPedido(int pedidoId, string cliente, string endereco, decimal valor, bool pagamentoConfirmado, bool estoqueDisponivel, bool entregaExpressa)
        {
            if (pagamentoConfirmado)
            {
                if (estoqueDisponivel)
                {
                    if (entregaExpressa)
                    {
                        Console.WriteLine($"Pedido {pedidoId} para {cliente} será enviado para {endereco} com entrega expressa.");
                    }
                    else
                    {
                        Console.WriteLine($"Pedido {pedidoId} para {cliente} será enviado para {endereco} com entrega normal.");
                    }
                }
                else
                {
                    Console.WriteLine($"Pedido {pedidoId} para {cliente} não pode ser processado devido à falta de estoque.");
                }
            }
            else
            {
                Console.WriteLine($"Pedido {pedidoId} para {cliente} não pode ser processado porque o pagamento não foi confirmado.");
            }
        }
    }
}
