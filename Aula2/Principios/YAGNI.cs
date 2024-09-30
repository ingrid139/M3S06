using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Principios
{
    public class YAGNI
    {
        // Código que implementa apenas a funcionalidade necessária
        public class Cliente
        {
            public string Nome { get; set; }
            public string Email { get; set; }

            // Método necessário para validar o email
            public bool ValidarEmail()
            {
                return Email.Contains("@");
            }
        }

    }
}
