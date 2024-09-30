using Aula1.Metodo;

namespace Aula1
{
    public class MetodosTamanho
    {
        //Antes
        public decimal CalcularTotalPedido(Pedido pedido)
        {
            decimal total = 0;
            foreach (var item in pedido.Itens)
            {
                total += item.Preco * item.Quantidade;
            }
            if (pedido.Desconto > 0)
            {
                total -= pedido.Desconto;
            }
            return total;
        }

        //Depois
        public decimal CalcularTotalPedido_(Pedido pedido)
        {
            decimal total = CalcularTotalItens(pedido.Itens);
            total = AplicarDesconto(total, pedido.Desconto);
            return total;
        }

        private decimal CalcularTotalItens(List<Item> itens)
        {
            decimal total = 0;
            foreach (var item in itens)
            {
                total += item.Preco * item.Quantidade;
            }
            return total;
        }

        private decimal AplicarDesconto(decimal total, decimal desconto)
        {
            return total - desconto;
        }
    }
}
