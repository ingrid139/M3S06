using Aula1.Metodo;

namespace Aula2.Refatoracao
{

    public class MetodoLongo
    {
        public void GerarRelatorioCompleto(List<Pedido> pedidos)
        {
            decimal totalVendas = 0;
            decimal totalDescontos = 0;

            foreach (var pedido in pedidos)
            {
                totalVendas += pedido.ValorTotal;
                totalDescontos += pedido.Desconto;
            }

            Console.WriteLine("Relatório Completo:");
            Console.WriteLine("Total de Vendas: " + totalVendas);
            Console.WriteLine("Total de Descontos: " + totalDescontos);
        }
    }
    public class MetodoLongoRefatorado
    {
        public void GerarRelatorioCompleto(List<Pedido> pedidos)
        {
            var totais = CalcularTotais(pedidos);
            ExibirRelatorio(totais);
        }

        private (decimal totalVendas, decimal totalDescontos) CalcularTotais(List<Pedido> pedidos)
        {
            decimal totalVendas = 0;
            decimal totalDescontos = 0;

            foreach (var pedido in pedidos)
            {
                totalVendas += pedido.ValorTotal;
                totalDescontos += pedido.Desconto;
            }

            return (totalVendas, totalDescontos);
        }

        private void ExibirRelatorio((decimal totalVendas, decimal totalDescontos) totais)
        {
            Console.WriteLine("Relatório Completo:");
            Console.WriteLine("Total de Vendas: " + totais.totalVendas);
            Console.WriteLine("Total de Descontos: " + totais.totalDescontos);
        }
    }
}
