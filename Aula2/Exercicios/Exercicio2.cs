
using Aula2.Refatoracao.Modelo;

namespace Aula2.Exercicios
{
    public class Exercicio2
    {
        public decimal Valor { get; set; }
        public bool ClienteVip { get; set; }
        public bool PrimeiraCompra { get; set; }
        public bool CupomDesconto { get; set; }

        public decimal CalcularDesconto()
        {
            decimal desconto = 0;

            if (ClienteVip)
            {
                if (PrimeiraCompra)
                {
                    desconto = Valor * 0.20m;
                }
                else
                {
                    desconto = Valor * 0.10m;
                }
            }
            else
            {
                if (PrimeiraCompra)
                {
                    desconto = Valor * 0.05m;
                }
                else if (CupomDesconto)
                {
                    desconto = Valor * 0.15m;
                }
                else
                {
                    desconto = Valor * 0.02m;
                }
            }

            return desconto;
        }
    }

    public class SugestaoRefatoracao
    {
        public decimal Valor { get; set; }
        public bool ClienteVip { get; set; }
        public bool PrimeiraCompra { get; set; }
        public bool CupomDesconto { get; set; }

        public decimal CalcularDesconto()
        {
            return ClienteVip ? CalcularDescontoClienteVip() : CalcularDescontoClienteComum();
        }

        private decimal CalcularDescontoClienteVip()
        {
            return PrimeiraCompra ? Valor * 0.20m : Valor * 0.10m;
        }

        private decimal CalcularDescontoClienteComum()
        {
            if (PrimeiraCompra)
            {
                return Valor * 0.05m;
            }
            if (CupomDesconto)
            {
                return Valor * 0.15m;
            }
            return Valor * 0.02m;
        }
    }
}
