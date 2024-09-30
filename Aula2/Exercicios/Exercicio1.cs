using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Exercicios
{
    public class Exercicio1
    {
        public string FormatarNomeCompleto(string primeiroNome, string sobrenome)
        {
            return primeiroNome + " " + sobrenome;
        }

        public string FormatarNomeCompletoComTitulo(string titulo, string primeiroNome, string sobrenome)
        {
            return titulo + " " + primeiroNome + " " + sobrenome;
        }
    }
}
