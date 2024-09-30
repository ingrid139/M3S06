namespace Aula1.Metodo
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Status { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Item> Itens { get; set; }

        // Classe com método que realiza uma ação diretamente
        public void Processar()
        {
            // Lógica de processamento do pedido
        }
    }

    public class Item
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}