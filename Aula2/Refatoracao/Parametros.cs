using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Refatoracao
{
    public class Parametros
    {
        //Antes
        public void AtualizarCliente(string nome, string sobrenome, string endereco, string cidade, string estado, string cep, string telefone, string email)
        {
            // Lógica para atualizar o cliente
        }

        //Refatorado
        public void AtualizarCliente(ClienteInfo clienteInfo)
        {
            // Lógica para atualizar o cliente
        }
    }
    public class ClienteInfo
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
