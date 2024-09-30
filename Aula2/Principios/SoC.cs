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
}
