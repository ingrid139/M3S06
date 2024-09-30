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
                return valor * 0.3m;
            }
            else
            {
                return 0;
            }
        }
    }
}
