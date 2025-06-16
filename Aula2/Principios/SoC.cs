using Aula1.Metodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Principios
{
    public class SoC
    {
        //Separe o software em partes distintas que encapsulam comportamentos únicos.

        public void ComunicarCliente()
        {
            // Uso das classes
            Usuario usuario = new() { Nome = "João", Email = "joao@example.com" };
            ServicoEmail servicoEmail = new();
            servicoEmail.EnviarEmail(usuario.Email, "Bem-vindo, João!");
        }
    }

    public class ServicoEmail
    {
        public void EnviarEmail(string email, string mensagem)
        {
            // Lógica para enviar email
        }
    }

    //exemplo2
    //antes
    public class Pedido
    {
        public void CriarPedido()
        {
            // Lógica para criar o pedido
        }

        public void CalcularTotal()
        {
            // Lógica para calcular o total do pedido
        }

        public void EnviarEmailConfirmacao()
        {
            // Lógica para enviar email de confirmação
        }
    }

    //DEPOIS
    /*No exemplo “Depois”, a responsabilidade de criar o pedido, calcular o total e enviar o email de confirmação foi separada em diferentes classes (Pedido, CalculadoraTotal e ServicoEmail). Isso segue o princípio SoC, tornando o código mais modular e fácil de manter*/
    public class Pedido_
    {
        public void CriarPedido()
        {
            // Lógica para criar o pedido
        }
    }

    public class CalculadoraTotal
    {
        public decimal CalcularTotal(Pedido pedido)
        {
            // Lógica para calcular o total do pedido
            return 0; // Exemplo simplificado
        }
    }

    public class ServicoEmail_
    {
        public void EnviarEmailConfirmacao(Pedido pedido)
        {
            // Lógica para enviar email de confirmação
        }
    }
}
