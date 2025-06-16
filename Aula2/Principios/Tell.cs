using Aula1;
using Aula1.Metodo;
using System.ComponentModel.DataAnnotations;

namespace Aula2.Principios
{
    public class Tell
    {
        //Diga aos objetos o que fazer, em vez de perguntar sobre seu estado e tomar decisões.

        public void Comprar()
        {
            // Uso do método
            Pedido pedido = new();
            pedido.Processar();
        }
    }

    //ANTES
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public void Depositar(decimal quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(decimal quantia)
        {
            if (quantia <= Saldo)
            {
                Saldo -= quantia;
            }
        }
    }

    public class Cliente
    {
        public void RealizarSaque(ContaBancaria conta, decimal quantia)
        {
            if (conta.Saldo >= quantia)
            {
                conta.Sacar(quantia);
            }
        }
    }

    //DEPOIS
    /*No exemplo “Depois”, o método RealizarSaque da classe Cliente não verifica o saldo da conta antes de realizar o saque. Em vez disso, ele simplesmente diz à ContaBancaria para realizar o saque, e a própria ContaBancaria lida com a verificação do saldo e lança uma exceção se o saldo for insuficiente. Isso segue o princípio “Tell, Don’t Ask” e mantém a lógica de negócio encapsulada dentro da classe ContaBancaria*/
    public class ContaBancaria_
    {
        public decimal Saldo { get; private set; }
        private readonly SaldoValidator _validator;

        public ContaBancaria_(SaldoValidator validator)
        {
            _validator = validator;
        }
        public void Depositar(decimal quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(decimal quantia)
        {
            _validator.Validar(Saldo, quantia);
            Saldo -= quantia;
        }
    }
    public class SaldoValidator
    {
        public void Validar(decimal saldo, decimal quantia)
        {
            if (quantia > saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
        }
    }

    public class Cliente_
    {
        public void RealizarSaque(ContaBancaria conta, decimal quantia)
        {
            conta.Sacar(quantia);
        }
    }    
}
