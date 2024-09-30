using Aula1.Metodo;

namespace Aula1
{
    public class MetodosResponsabilidadeUnica
    {
    }

    public class PedidoServiceAntes
    {
        public void ProcessarPedido(Pedido pedido)
        {
            if (pedido.Itens.Count == 0)
            {
                throw new Exception("Pedido sem itens.");
            }
            // Processamento do pedido
        }
    }

    public class PedidoServiceDepois
    {
        private readonly PedidoValidator _validator;

        public PedidoServiceDepois(PedidoValidator validator)
        {
            _validator = validator;
        }

        public void ProcessarPedido(Pedido pedido)
        {
            _validator.Validar(pedido);
            // Processamento do pedido
        }
    }

    public class PedidoValidator
    {
        public void Validar(Pedido pedido)
        {
            if (pedido.Itens.Count == 0)
            {
                throw new Exception("Pedido sem itens.");
            }
        }
    }
}
