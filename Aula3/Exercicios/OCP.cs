namespace Aula3.Exercicios
{
    public class OCP
    {
        //o código da classe abaixo está violando o principio de aberto/fechado. Reescreva aplicando a correção
    }
    public class CalculadoraDesconto
    {
        public decimal CalcularDesconto(string tipoCliente, decimal valor)
        {
            if (tipoCliente == "Regular")
            {
                return valor * 0.1m;
            }
            else if (tipoCliente == "Premium")
            {
                return valor * 0.2m;
            }
            else if (tipoCliente == "VIP")
            {
                Console.WriteLine("Calculando cliente VIP");
                return valor * 0.3m;
            }
            else
            {
                return 0;
            }
        }
    }

    public interface IDesconto
    {
        decimal Calcular(decimal valor);
    }

    public class DescontoRegular : IDesconto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.1m;
        }
    }

    public class DescontoPremium : IDesconto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.2m;
        }
    }

    public class DescontoVIP : IDesconto
    {
        public decimal Calcular(decimal valor)
        {
            Console.WriteLine("Calculando cliente VIP");
            return valor * 0.3m;
        }
    }

    public class CalculadoraDesconto_
    {
        public decimal CalcularDesconto(IDesconto desconto, decimal valor)
        {
            return desconto.Calcular(valor);
        }
    }
}
