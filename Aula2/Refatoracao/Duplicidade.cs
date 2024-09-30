namespace Aula2.Refatoracao
{
    public class Duplicidade
    {
        public double CalcularTotal(double valorItem, int quantidadeItem, double imposto, double desconto)
        {
            double total = (valorItem * quantidadeItem) + imposto - desconto;
            return total;
        }

        public double CalcularTotalComFrete(double valorItem, int quantidadeItem, double imposto, double desconto, double frete)
        {
            double total = (valorItem * quantidadeItem) + imposto - desconto + frete;
            return total;
        }
    }

    public class DeuplicidadeRefatorada
    {
        public double CalcularTotal(double valorItem, int quantidadeItem, double imposto, double desconto, double frete = 0)
        {
            double total = (valorItem * quantidadeItem) + imposto - desconto + frete;
            return total;
        }
    }
}
